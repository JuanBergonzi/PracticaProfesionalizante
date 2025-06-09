using ServiceReference2;

namespace EjSoap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.CountryInfoServiceSoapTypeClient client = 
                new ServiceReference2.CountryInfoServiceSoapTypeClient(ServiceReference2.CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);

            tCountryCodeAndName[] lista = client.ListOfCountryNamesByCode();

            MessageBox.Show("El pais nro 10 es;"+ lista[10].sName);
        }
    }
}
