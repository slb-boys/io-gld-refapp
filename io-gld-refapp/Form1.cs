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

        private void Run_Glue()
        {
            // Start winglue via EXE path or COM
            // and exe path is in registry, but you might want an application pool
        }

        private Client Connect_Glue(String net_address, int wg_port)
        {
            // This will talk to WinGLUE
            return new Client(String.Format("http://{0}:{1}", net_address, wg_port));
        }
        private Client Connect_Glue()
        {
            try
            {
                // We will have to find a way to start WinGLUE on a different port
                String net_address = "localhost";
                int wg_port = 8080;

                // open and retain connection
                Client rpcClient = Connect_Glue(net_address, wg_port);
                return rpcClient;
            }
            catch (Exception ex) {
                outputBox.AppendLine("Oh damn, did not get a glue connection") ;
                throw; // rethrow
            }
            return null; // not get here
        }
        private void Test_Glue_Connect(Client rpcClient)
        {
            // This will talk to WinGLUE
            // Prepare a call "request"
            String a_string = "Hello Sucker";
            Request rq =  rpcClient.NewRequest("Echo", a_string);

            // Call a remote function
            GenericResponse response = rpcClient.Rpc(rq);
            if (response.Result == null)
            {
                // WinGLUE not there
                throw new Exception(string.Format("Error in response, code:{0} message:{1}",
                    response.Error.Code, response.Error.Message));
            }

            // got something back
            JToken result = response.Result;

            // Check return collection, just for show
            if (result.HasValues)
            {
                // WinGLUE API version not matched
                throw new Exception(string.Format("Hey man, someing handed back non-scalar"));
            }

            // Should be a specific string
            if (result.ToString() != a_string){
                // WinGLUE API version not matched
                throw new Exception(string.Format("Remote does not recognize me"));
            }

            outputBox.AppendLine(string.Format("WinGLUE says: \"{0}\"", result.ToString()));
        }

        private void print_result_base(String function_name, JToken result)
        {
            if (result == null )
            {
                outputBox.AppendLine("{0} null result!");
            }
            outputBox.AppendLine(String.Format("{0}(): received {1}", function_name, result.Count()));
        }

        private void print_string_list(String function_name, JToken result)
        {
            print_result_base(function_name, result);

            // dump each item
            foreach ( String str in result) {
                outputBox.AppendLine(str);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startGlue_Click(object sender, EventArgs e)
        {

            // Client start out null until created
            if (this.ii > 0 )
            {
                outputBox.AppendLine("Only start WinGLUE once, you hockey puck");
                return; // get out
            }

            Run_Glue();
            Client rpcClient = Connect_Glue();
            Test_Glue_Connect( rpcClient);
            this.ii++; // been here
        }


        private void pullModel_Click(object sender, EventArgs e)
        {
            using (Client rpcClient = Connect_Glue()) {

                String function_name = "getGraphList";
                Request rq = rpcClient.NewRequest(function_name);
                GenericResponse response = rpcClient.Rpc(rq);

                if (response.Result == null)
                {
                    outputBox.AppendLine(string.Format("Error in response, code:{0} message:{1}",
                        response.Error.Code, response.Error.Message));
                    return;
                }

                JToken result = response.Result;
                print_string_list(function_name, result);
            }
        }



        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDataSources_Click(object sender, EventArgs e)
        {
            using (Client rpcClient = Connect_Glue())
            {

                String function_name = "GetDataSources";
                Request rq = rpcClient.NewRequest(function_name);
                GenericResponse response = rpcClient.Rpc(rq);

                if (response.Result == null)
                {
                    outputBox.AppendLine(string.Format("Error in response, code:{0} message:{1}",
                        response.Error.Code, response.Error.Message));
                    return;
                }

                JToken result = response.Result;
                print_string_list(function_name, result);

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
