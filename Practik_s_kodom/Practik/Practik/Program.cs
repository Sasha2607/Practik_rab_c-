using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik
{
     public static class data
    {
         public static string box { get; set; }

         public static string D1 { get; set; }
         public static string D2 { get; set; }
         public static string D3 { get; set; }
         public static string D4 { get; set; }
         public static string D5 { get; set; }
         public static string D6 { get; set; }

         public static string A1 { get; set; }
         public static string A2 { get; set; }
         public static string A3 { get; set; }
         public static string A4 { get; set; }
         public static string A5 { get; set; }
         public static string A10 { get; set; }
         public static string A11 { get; set; }
         public static string A12 { get; set; }

         public static string A1id { get; set; }
         public static string A2id { get; set; }
         public static string A3id { get; set; }

         public static string B1 { get; set; }
         public static string B2 { get; set; }
         public static string B3 { get; set; }
         public static string B4 { get; set; }

         public static string C1 { get; set; }
         public static string C2 { get; set; }

         public static string R1 { get; set; }
         public static string R2 { get; set; }
         public static string R3 { get; set; }
         public static string R4 { get; set; }
         public static string R5 { get; set; }
         public static string R6 { get; set; }

         public static string avto { get; set; }
         public static string E01 { get; set; }
         public static string E02 { get; set; }

         public static string E1 { get; set; }
         public static string E2 { get; set; }
         public static string E3 { get; set; }
         public static string E4 { get; set; }
         public static string E5 { get; set; }


         public static string prixod { get; set; }
         public static string post { get; set; }
         public static string z1 { get; set; }
         public static string z2id { get; set; }
         public static string z2 { get; set; }
         public static string z3 { get; set; }
         public static string z11 { get; set; }
         public static string z12 { get; set; }
         public static string z13id { get; set; }
         public static string z14 { get; set; }
         public static string z15 { get; set; }



        public static string z35 { get; set; }


        public static string Client { get; set; }
        public static string clientID { get; set; }
        public static string client1 { get; set; }
        public static string client2 { get; set; }
        public static string client3 { get; set; }
        public static string client4 { get; set; }
        public static string clientFIOID { get; set; }
        public static string clientName1 { get; set; }
        public static string clientName2 { get; set; }
        public static string clientName3 { get; set; }



















        public static string Gorod1 { get; set; }
         public static string G1id { get; set; }
         public static string G1name { get; set; }
         public static string G2id { get; set; }
         public static string G2name { get; set; }

         public static string Vod1 { get; set; }
         public static string  Vod1id { get; set; }
         public static string Vod1name { get; set; }
         public static string Vod2name { get; set; }
        public static string Vod3name { get; set; }

        public static string Mark1 { get; set; }
         public static string Mark1id1 { get; set; }
        public static string Mark1id2 { get; set; }
        public static string Mark1name { get; set; }
        public static string Mark1GOS { get; set; }

        public static string Top1 { get; set; }
         public static string Top1id { get; set; }
         public static string Top1name { get; set; }

         public static string Postavka1 { get; set; }
         public static string Postavka1id { get; set; }
         public static string Postavka1name { get; set; }

         public static string AYE1Id { get; set; }
         public static string AYE1 { get; set; }
         public static string AYE2 { get; set; }
         public static string AYE3 { get; set; }


         public static string toplivo { get; set; }
     }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
