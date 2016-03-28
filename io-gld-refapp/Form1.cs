using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 
using JsonRPC;
using Newtonsoft.Json.Linq;

namespace io_gld_refapp
{
    public partial class Form1 : Form
    {
        private int ii = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void startGlue_Click(object sender, EventArgs e)
        {
            if (this.ii==0)
            {
                outputBox.Text = ii.ToString();
            }
            else
            {
                outputBox.AppendText("\r\n" + ii.ToString());
            }
            ii++;
        
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pullModel_Click(object sender, EventArgs e)
        {
            using (Client rpcClient = new Client("http://localhost:8080"))
            {
                Request rq = rpcClient.NewRequest("getGraphList");
                GenericResponse response = rpcClient.Rpc(rq);

                if (response.Result == null)
                {
                    Console.WriteLine(string.Format("Error in response, code:{0} message:{1}",
                        response.Error.Code, response.Error.Message));
                }
                JToken result = response.Result;
                outputBox.AppendText(result.FirstOrDefault().ToString());

            }
        }
    }
}

public static class WinFormsExtensions
{
    public static void AppendLine(this TextBox source, string value)
    {
        if (source.Text.Length == 0)
            source.Text = value;
        else
            source.AppendText("\r\n" + value);
    }
}
