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
                var net_address = "localhost";
                var wg_port = 8080;

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
            var a_string = "Hello Sucker";
            var rq =  rpcClient.NewRequest("Echo", a_string);

            // Call a remote function
            var response = rpcClient.Rpc(rq);
            if (response.Result == null)
            {
                // WinGLUE not there
                throw new Exception(string.Format("Error in response, code:{0} message:{1}",
                    response.Error.Code, response.Error.Message));
            }

            // got something back
            var result = response.Result;

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
            foreach ( var jtok in result) {
                if (jtok.HasValues)
                {
                    foreach (var val in jtok)
                    {
                        outputBox.AppendLine(val.ToString());
                    }
                }
                {
                    outputBox.AppendLine(jtok.ToString());
                }
            }
        }

        private JToken call_glue(String function_name, JContainer jo)
        {
            using (Client rpcClient = Connect_Glue())
            {
                var rq = rpcClient.NewRequest(function_name, jo);
                var response = rpcClient.Rpc(rq);

                if (response.Result == null)
                {
                    outputBox.AppendLine(string.Format("{0} Error in response, code:{1} message:{2}",
                        function_name, response.Error.Code, response.Error.Message));
                    return null;
                }

                var result = response.Result;
                print_string_list(function_name, result);
                return result;
            } // using
        } // call_glue

        private JToken call_glue(String function_name)
        {
            using (Client rpcClient = Connect_Glue())
            {
                var rq = rpcClient.NewRequest(function_name);
                var response = rpcClient.Rpc(rq);

                if (response.Result == null)
                {
                    outputBox.AppendLine(string.Format("{0} Error in response, code:{1} message:{2}",
                        function_name, response.Error.Code, response.Error.Message));
                    return null;
                }

                var result = response.Result;
                print_string_list(function_name, result);
                return result;
            } // using
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
            var rpcClient = Connect_Glue();
            Test_Glue_Connect( rpcClient);
            this.ii++; // been here
        }


        private void pullModel_Click(object sender, EventArgs e)
        {
            call_glue("GetGraphList");
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDataSources_Click(object sender, EventArgs e)
        {
            var result = call_glue("GetDataSources");
            cmbDataSources.DataSource = result;
        }

        private String get_data_source()
        {
            // get the selected data source
            var data_source = cmbDataSources.Text;
            if (data_source.Length < 1)
            {
                outputBox.AppendLine("No data source selected");
            }
            return data_source;
        }

        private int get_field_id()
        {
            // get the selected field
            var field_item = (JObject)cmbFields.SelectedItem;
            int field_id = 0;
            if (field_item == null)
            {
                outputBox.AppendLine("No field selected");
            }
            else {
                var field_id_str = field_item.GetValue("field_id").ToString();
                field_id = int.Parse(field_id_str);
            }
            return field_id;
        }
        private String get_lease_name()
        {
            // get the selected lease
            var lease_item = (JObject)cmbLeases.SelectedItem;
            var lease_name = "";
            if (lease_item == null)
            {
                outputBox.AppendLine("No lease selected");
            }
            else {
                lease_name = lease_item.GetValue("lease_name").ToString();
            }
            return lease_name;
        }

        private void btnFields_Click(object sender, EventArgs e)
        {
            var data_source = get_data_source() ;
            if (data_source.Length < 1) return;

            // Stuff in a JSON object
            var cinst = new {
                data_source_name = data_source,
            };
            var param = JObject.FromObject(cinst) ;

            // call glue
            var result = call_glue("GetFields_Data", param);

            // put in list box
            cmbFields.DataSource = result;
            cmbFields.DisplayMember = "field_name";
        }

        private void btnLeases_Click(object sender, EventArgs e)
        {
            var data_source = get_data_source() ;
            if (data_source.Length < 1) return;
            var field_id = get_field_id() ;
            if (field_id < 1) return;

            // Stuff in a JSON object
            var cinst = new {
                data_source_name = data_source,
                field_id = field_id
            };
            var param = JObject.FromObject(cinst);

            // call glue
            var result = call_glue("GetLeases_Data", param);

            // connect combobox to LINQ result
            cmbLeases.DataSource = result;
            cmbLeases.DisplayMember = "lease_name";
        }

        private void btnWells_Click(object sender, EventArgs e)
        {

            var data_source = get_data_source() ;
            if (data_source.Length < 1) return;
            var field_id = get_field_id() ;
            if (field_id < 1) return;
            var lease_name = get_lease_name() ;
            if (lease_name.Length < 1) return;

            // Stuff in a JSON object
            var cinst = new {
                data_source_name = data_source,
                field_id = field_id,
                lease_name = lease_name
            };
            var param = JObject.FromObject(cinst);

            // call glue
            var result = call_glue("GetWells_Data", param);

            // put in list box
            cmbWells.DataSource = result;
            cmbWells.DisplayMember = "well_name";
        }
    } // form
} // namespace

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