using System.Net.Sockets;
using System.IO;
namespace client_sideWF
{


    // hello
    public partial class SEND : Form
    {
        public SEND()
        {
            InitializeComponent();
        }
        string n;
        byte[] b1;
        OpenFileDialog op;

        private void button2_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("MSI", 5055);
            Stream s = client.GetStream();
            b1 = File.ReadAllBytes(op.FileName);
            s.Write(b1, 0, b1.Length);
            client.Close();
            label1.Text = "File Transferred....";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string t = Textbox1.Text;
                t = op.FileName;
                FileInfo fi = new FileInfo(Textbox1.Text = op.FileName);
                n = fi.Name + "." + fi.Length;
                TcpClient client = new TcpClient("MSI",5050);
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(n);
                sw.Flush();
                label1.Text = "File Transferred....";
            }
        }

    }
}