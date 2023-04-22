using MAC_Quotation.Manufacture.Chevrolet.Chev_Brand;
using MAC_Quotation.Manufacture.Renault.Renault_Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MAC_Quotation
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void myManufactureComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected item from myManufactureComboBox
            ComboBoxItem selectedItem = myManufactureComboBox.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                // Check if "Select a Manufacture" is selected
                if (selectedItem.Content.ToString() == "-- Select a Manufacture --")
                {
                    // Hide myModelComboBox and myModel text block if "Select a Manufacture" is selected
                    myModelComboBox.Visibility = Visibility.Collapsed;
                    myModel.Visibility = Visibility.Collapsed;
                    return;
                }

                // Show myModelComboBox and myModel text block
                myModelComboBox.Visibility = Visibility.Visible;
                myModel.Visibility = Visibility.Visible;

                // Get the selected manufacturer
                string selectedManufacturer = selectedItem.Content.ToString();

                // Update the items in myModelComboBox based on the selected manufacturer
                switch (selectedManufacturer)
                {
                    case "AUDI":
                        myModelComboBox.ItemsSource = new List<string> { "A5", "Q5" };
                        break;
                    case "BMW":
                        myModelComboBox.ItemsSource = new List<string> { "320i", "320d" };
                        break;
                    case "Citroen":
                        myModelComboBox.ItemsSource = new List<string> { "Berlingo" };
                        break;
                    case "Chevrolet":
                        myModelComboBox.ItemsSource = new List<string> { "Spark", "Cruze LS", "Chev_Utility" };
                        break;
                    case "Datsun":
                        myModelComboBox.ItemsSource = new List<string> { "GO" };
                        break;
                    case "Ford":
                        myModelComboBox.ItemsSource = new List<string> { "Ranger", "Fiesta", "EcoSport", "Figo" };
                        break;
                    case "Hyundai":
                        myModelComboBox.ItemsSource = new List<string> { "i10", "i20", "Grand i10","i30", "Accent", "H1", "Tuscan", "Venue" };
                        break;
                    case "KIA":
                        myModelComboBox.ItemsSource = new List<string> { "Cerato", "Picanto" };
                        break;
                    case "Mazda":
                        myModelComboBox.ItemsSource = new List<string> { "Mazda 3" };
                        break;
                    case "Nissan":
                        myModelComboBox.ItemsSource = new List<string> { "NP200", "Almera", "Micra", "Qashqai" };
                        break;
                    case "Opel":
                        myModelComboBox.ItemsSource = new List<string> {  "Astra" };
                        break;
                    case "Peugeot":
                        myModelComboBox.ItemsSource = new List<string> { "207", "307" };
                        break;
                    case "Renault":
                        myModelComboBox.ItemsSource = new List<string> { "Kwid", "Sandero", "Capture", "Clio", "Stepway", "Triber", "Megane" };
                        break;
                    case "Suzuki":
                        myModelComboBox.ItemsSource = new List<string> { "Swift" };
                        break;
                    case "Toyota":
                        myModelComboBox.ItemsSource = new List<string> { "Yaris", "Corolla", "Tazz", "Quantum", "Etios", "Avanza", "Hilux" };
                        break;
                    case "VW":
                        myModelComboBox.ItemsSource = new List<string> { "Jetta", "Polo", "Golf", "Tiguan" };
                        break;
                    // Add cases for other manufacturers
                    default:
                        myModelComboBox.ItemsSource = null; // No items to display
                        break;
                }
            }
            else
            {
                // Hide myModelComboBox and myModel text block if no item is selected
                myModelComboBox.Visibility = Visibility.Collapsed;
                myModel.Visibility = Visibility.Collapsed;
            }
        }

        private void myModelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModel = myModelComboBox.SelectedItem as string;

            if (selectedModel != null)
            {
                switch (selectedModel)
                {

//***************************************************** AUDI *************************************************************************
                    case "A5":
                        // Navigate to the A5Window
                        Manufacture.Audi.Audi_Brand.A5 a5 = new Manufacture.Audi.Audi_Brand.A5();
                        a5.Show();
                        Close();
                        break;
                    case "Q5":
                        // Navigate to the Q5Window
                        Manufacture.Audi.Audi_Brand.Q5 q5 = new Manufacture.Audi.Audi_Brand.Q5();
                        q5.Show();
                        Close();
                        break;

//****************************************************** BMW *************************************************************************
                    case "320i":
                        // Navigate to the 320iWindow
                        Manufacture.BMW.BMW_Brand._320i _320I = new Manufacture.BMW.BMW_Brand._320i();
                        _320I.Show();
                        Close();
                        break;
                    case "320d":
                        // Navigate to the 320dWindow
                        Manufacture.BMW.BMW_Brand._320d _320D = new Manufacture.BMW.BMW_Brand._320d();
                        _320D.Show(); 
                        Close();
                        break;

//***************************************************** CHEVROLET *******************************************************************
                    case "Chev_Utility":
                        // Navigate to the Chev_UtilityWIndow
                        Manufacture.Chevrolet.Chev_Brand.Chev_Utility chev_Utility = new Manufacture.Chevrolet.Chev_Brand.Chev_Utility();
                        chev_Utility.Show();
                        Close();
                        break;
                    case "Spark":
                        // Navigate to the SparkWIndow
                        Manufacture.Chevrolet.Chev_Brand.Spark spark = new Manufacture.Chevrolet.Chev_Brand.Spark();
                        spark.Show();
                        Close();
                        break;
                    case "Cruze_LS":
                        // Navigate to the CruzeLS
                        Manufacture.Chevrolet.Chev_Brand.Cruze_LS cruze_LS = new Manufacture.Chevrolet.Chev_Brand.Cruze_LS();
                        cruze_LS.Show();
                        Close();
                        break;

//****************************************************** CITROEN *****************************************************************************
                    case "Berlingo":
                        // NAvigate to the BerlingoWindow
                        Manufacture.Citroen.Citroen_Brand.Berlingo berlingo = new Manufacture.Citroen.Citroen_Brand.Berlingo();
                        berlingo.Show(); 
                        Close();
                        break;

//********************************************************* DATSUN ****************************************************************
                    case "GO":
                        // Navigate to the GoWindow
                        Manufacture.Datsun.Datsun_Brand.GO gO = new Manufacture.Datsun.Datsun_Brand.GO();
                        gO.Show();
                        Close();
                        break;

//********************************************************* FORD *********************************************************************
                    case "EcoSport":
                        // Navigate to the ExoSportWindow
                        Manufacture.Ford.Ford_Brand.EcoSport ecoSport = new Manufacture.Ford.Ford_Brand.EcoSport();
                        ecoSport.Show(); 
                        Close();
                        break;
                    case "Fiesta":
                        // Navigate to the FiestaWindow
                        Manufacture.Ford.Ford_Brand.Fiesta fiesta = new Manufacture.Ford.Ford_Brand.Fiesta();
                        fiesta.Show();
                        Close();
                        break;
                    case "Ranger":
                        // Navigate to the RangerWindow
                        Manufacture.Ford.Ford_Brand.Ranger ranger = new Manufacture.Ford.Ford_Brand.Ranger();
                        ranger.Show();
                        Close();
                        break;
                    case "Figo":
                        // Navigate to the FigoWindow
                        Manufacture.Ford.Ford_Brand.Figo figo = new Manufacture.Ford.Ford_Brand.Figo();
                        figo.Show();
                        Close();
                        break;

//****************************************************** HYUNDAI *****************************************************************
                    case "Accent":
                        // Navigate to the AccentWindow
                        Manufacture.Hyundai.Accent accent = new Manufacture.Hyundai.Accent();
                        accent.Show();
                        Close();
                        break;
                    case "Grand i10":
                        // Navigate to the Grand_i10Window
                        Manufacture.Hyundai.Grand_i10 grand_I10 = new Manufacture.Hyundai.Grand_i10();
                        grand_I10.Show();
                        Close();
                        break;
                    case "H1":
                        // Navigate to the H1Window
                        Manufacture.Hyundai.H1 h1 = new Manufacture.Hyundai.H1();
                        h1.Show();
                        Close();
                        break;
                    case "i10":
                        // Navigate to the i10Window
                        Manufacture.Hyundai.i10 i10 = new Manufacture.Hyundai.i10();
                        i10.Show();
                        Close();
                        break;
                    case "i20":
                        // Navigate to the i20Window
                        Manufacture.Hyundai.i20 i20 = new Manufacture.Hyundai.i20();
                        i20.Show();
                        Close();
                        break;
                    case "i30":
                        // Navigate to the i30Window
                        Manufacture.Hyundai.i30 i30 = new Manufacture.Hyundai.i30();
                        i30.Show();
                        Close();
                        break;
                    case "Tuscan":
                        // Navigate to the PicantoWindow
                        Manufacture.Hyundai.Tuscan tuscan = new Manufacture.Hyundai.Tuscan();
                        tuscan.Show();
                        Close();
                        break;
                    case "Venue":
                        // Navigate to the VenueWindow
                        Manufacture.Hyundai.Venue venue = new Manufacture.Hyundai.Venue();
                        venue.Show();
                        Close();
                        break;

//**************************************************************** KIA ***********************************************
                    case "Cerato":
                        // Navigate to the CeratoWindow
                        Manufacture.Kia.Kia_Brand.Cerato cerato = new Manufacture.Kia.Kia_Brand.Cerato();
                        cerato.Show();
                        Close();
                        break;
                    case "Picanto":
                        // Navigate to the PicantoWindow
                        Manufacture.Kia.Kia_Brand.Picanto picanto = new Manufacture.Kia.Kia_Brand.Picanto();
                        picanto.Show();
                        Close();
                        break;

//****************************************************************** MAZDA ********************************************
                    case "Mazda 3":
                        // Navigate to the Mazda 3Window
                        Manufacture.Mazda.Mazda_Brand.Mazda_3 mazda_3 = new Manufacture.Mazda.Mazda_Brand.Mazda_3();
                        mazda_3.Show();
                        Close();
                        break;
                    case "Almera":
                        // Navigate tot he AlmeraWindow
                        Manufacture.Nissan.Nissan_Brand.Almera almera = new Manufacture.Nissan.Nissan_Brand.Almera();
                        almera.Show();
                        Close();
                        break;
                    case "Micra":
                        // Navigate to the MicraWindow
                        Manufacture.Nissan.Nissan_Brand.Micra micra = new Manufacture.Nissan.Nissan_Brand.Micra();
                        micra.Show();
                        Close();
                        break;
                    case "NP200":
                        // Navigate tot he NP200Window
                        Manufacture.Nissan.Nissan_Brand.NP200 nP200 = new Manufacture.Nissan.Nissan_Brand.NP200();
                        nP200.Show();
                        Close();
                        break;
                    case "Qashqai":
                        // Navigate to the QashqaiWindow
                        Manufacture.Nissan.Nissan_Brand.Qashqai qashqai = new Manufacture.Nissan.Nissan_Brand.Qashqai();
                        qashqai.Show();
                        Close();
                        break;

//************************************************************** OPEL *************************************************************
                    case "Astra":
                        // Navigate to the Astra Menu
                        Manufacture.Opel.Opel_Brand.Astra astra = new Manufacture.Opel.Opel_Brand.Astra();
                        astra.Show();
                        Close();
                        break;

//********************************************************** PEUGEOT ***********************************************************
                    case "207":
                        // Navigate tot he 207Window
                        Manufacture.Peugeaot.Peugeot_Brand._207 _207 = new Manufacture.Peugeaot.Peugeot_Brand._207();
                        _207.Show();
                        Close();
                        break;
                    case "307":
                        // Navigate to the 307Window
                        Manufacture.Peugeaot.Peugeot_Brand._307 _307 = new Manufacture.Peugeaot.Peugeot_Brand._307();
                        _307.Show(); 
                        Close();
                        break;

//*********************************************************************** RENAULT ***********************************************
                    case "Capture":
                        // Navigate to the CaptureWindow
                        Manufacture.Renault.Renault_Brand.Capture capture = new Manufacture.Renault.Renault_Brand.Capture();
                        capture.Show();
                        Close();
                        break;
                    case "Clio":
                        // Navigate to the ClioWindow
                        Manufacture.Renault.Renault_Brand.Clio clio = new Manufacture.Renault.Renault_Brand.Clio();
                        clio.Show();
                        Close();
                        break;
                    case "Kwid":
                        // Navigate to the KwidWindow
                        Manufacture.Renault.Renault_Brand.Kwid kwid = new Manufacture.Renault.Renault_Brand.Kwid();
                        kwid.Show();
                        Close();
                        break;
                    case "Megane":
                        // Navigate to the MeganeWindow
                        Manufacture.Renault.Renault_Brand.Megane megane = new Manufacture.Renault.Renault_Brand.Megane();
                        megane.Show();
                        Close();
                        break;
                    case "Sandero":
                        // Navigate to the SanderoWindow
                        Manufacture.Renault.Renault_Brand.Sandero sandero = new Manufacture.Renault.Renault_Brand.Sandero();
                        sandero.Show();
                        Close();
                        break;
                    case "Stepway":
                        // Navigate to the StepwayWindow
                        Manufacture.Renault.Renault_Brand.Stepway stepway = new Manufacture.Renault.Renault_Brand.Stepway();
                        stepway.Show();
                        Close();
                        break;
                    case "Triber":
                        // Navigate to the TriberWindow
                        Manufacture.Renault.Renault_Brand.Triber triber = new Manufacture.Renault.Renault_Brand.Triber();
                        triber.Show();
                        Close();
                        break;

//******************************************************** SUZUKI *****************************************************************
                    case "Swift":
                        // Navigate to the SwiftWindow
                        Manufacture.Suzuki.Suzuki_Brand.Swift swift = new Manufacture.Suzuki.Suzuki_Brand.Swift();
                        swift.Show();
                        Close();
                        break;

//************************************************************************ TOYOTA ****************************************************
                    case "Avanza":
                        // Navigt to the AvanzaWindow
                        Manufacture.Toyota.Toyota_Brand.Avanza avanza = new Manufacture.Toyota.Toyota_Brand.Avanza();
                        avanza.Show();
                        Close();
                        break;
                    case "Corolla":
                        // Navigate to the CorollaWindow
                        Manufacture.Toyota.Toyota_Brand.Corolla corolla = new Manufacture.Toyota.Toyota_Brand.Corolla();
                        corolla.Show();
                        Close();
                        break;
                    case "Etios":
                        // Navigate to the EtiosWindow
                        Manufacture.Toyota.Toyota_Brand.Etios etios = new Manufacture.Toyota.Toyota_Brand.Etios();
                        etios.Show();
                        Close();
                        break;
                    case "Hilux":
                        // Navigate to the HiluxWindow
                        Manufacture.Toyota.Toyota_Brand.Hilux hilux = new Manufacture.Toyota.Toyota_Brand.Hilux();
                        hilux.Show();
                        Close();
                        break;
                    case "Quantum":
                        // Navigate to the QuantumWindow
                        Manufacture.Toyota.Toyota_Brand.Quntum quntum = new Manufacture.Toyota.Toyota_Brand.Quntum();
                        quntum.Show();
                        Close();
                        break;
                    case "Tazz":
                        // Navigate to the TazzWindow
                        Manufacture.Toyota.Toyota_Brand.Tazz tazz = new Manufacture.Toyota.Toyota_Brand.Tazz();
                        tazz.Show();
                        Close();
                        break;
                    case "Yaris":
                        // Navigate to the YarisWindow
                        Manufacture.Toyota.Toyota_Brand.Yaris yaris = new Manufacture.Toyota.Toyota_Brand.Yaris();
                        yaris.Show();
                        Close();
                        break;


//******************************************************************** VW ************************************************
                    case "Golf":
                        // Navigate to the GolfWindow
                        Manufacture.VW.VW_Brand.Golf golf = new Manufacture.VW.VW_Brand.Golf();
                        golf.Show();
                        Close();
                        break;
                    case "Jetta":
                        // Navigate to the JettaWindow
                        Manufacture.VW.VW_Brand.Jetta jetta = new Manufacture.VW.VW_Brand.Jetta();
                        jetta.Show();
                        Close();
                        break;
                    case "Polo":
                        // Navigate to the PoloWindow
                        Manufacture.VW.VW_Brand.Polo polo = new Manufacture.VW.VW_Brand.Polo();
                        polo.Show();
                        Close();
                        break;
                    case "Tiguan":
                        // Navigate to the TiguanWindow
                        Manufacture.VW.VW_Brand.Tiguan tiguan = new Manufacture.VW.VW_Brand.Tiguan();
                        tiguan.Show();
                        Close();
                        break;
                        // Add cases for other models
                    default:
                        // Do nothing
                        break;
                }
            }
        }



    }
}
