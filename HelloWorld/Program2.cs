using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Management;

namespace HelloWorld
{
    class Program
    {
        private static void Main()
        {

            //Cenogram!!!!!!!!!!!!!!!!!!


            try
            {
                ConnectionOptions connectionOptions = new ConnectionOptions();

                connectionOptions.Username = @"t2_tnielse5";
                connectionOptions.Password = "6Dieinafire^";
                connectionOptions.Impersonation = ImpersonationLevel.Impersonate;
                string machinename = "TXFRILP0719943";

                ManagementScope scope = new ManagementScope("\\\\" + machinename + "\\root\\CIMV2", connectionOptions);

                scope.Connect();

                ManagementClass clas = new ManagementClass(scope, new ManagementPath("Win32_Process"), new ObjectGetOptions());

                ManagementBaseObject inparams = clas.GetMethodParameters("Create");

                Console.WriteLine("Computer Name Is:", machinename);


                inparams["CommandLine"] = "GPUpdate /force";
               
                ManagementBaseObject outparam = clas.InvokeMethod("Create", inparams, null);
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
