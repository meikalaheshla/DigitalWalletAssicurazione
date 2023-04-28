using System;
using System.Runtime.InteropServices;

namespace DigitalWalletAssicurazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EUDigitalWallet DigitalWallet = new EUDigitalWallet("BSHDKNCs34353K");
            
            Assicurazione.CreatePlan(DigitalWallet.GetClinicalSituation());
           
            
            
        }
    }
    public class AssuranceIntermediary {
        public class ClinicalWallet
        {
            string _clinicalStatus;

            public ClinicalWallet(string ClinicalStatus)
            {
                _clinicalStatus = ClinicalStatus;
            }

        }

    }
        public class EUDigitalWallet : AssuranceIntermediary
        {
            string _owner;
            string _diploma = "Maturita";
            string _taxinfo = "";
            bool _penalStatus = false;

            public EUDigitalWallet(string CF)
            {
                _owner = CF;
            }

       

            public string GetDiploma()
            {
                Console.WriteLine(_diploma);

                return _diploma;
            }
            public bool GetPenalStatus()
            {
                Console.WriteLine(_penalStatus);
                return _penalStatus;
            }
            public ClinicalWallet GetClinicalSituation()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                ClinicalWallet clinicalWallet = new ClinicalWallet("Sta bene");
                Console.ResetColor();
                return clinicalWallet;
            }
            public string GetTaxInfo()
            {
                Console.WriteLine(_taxinfo);
                return _taxinfo;
            }
        }

    class Person
    {
        public string CF { get; set; }
    }

    public class Assicurazione : AssuranceIntermediary
    {
       
        public static void CreatePlan(ClinicalWallet clinicalWallet)
        {
            var ClinicalData = clinicalWallet;
           Console.WriteLine("piano finanziario creato");

        }
    }
}
