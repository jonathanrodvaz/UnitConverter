namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private ConverterService _converterService;
        public Form1()
        {
            InitializeComponent();
            _converterService = new ConverterService();

            cmbType.DataSource = Enum.GetValues(typeof(TypeEnum));
            //En la siguiente linea vamos a establecer el estilo del dropdown, de esta manera que vemos a continuación vamos a hacer que el desplegable no sea editable, que solo muestre las opciones que hay predefinidas y no deje al usuario escribir encima.
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Borramos lo introducido en la operación anterior en el momento que cambiamos de unidad de medida*/
            txtAmount.Text = String.Empty;
            txtConvertedAmount.Text = String.Empty;


            var type = (TypeEnum)cmbType.SelectedItem;

            switch (type)
            {
                case TypeEnum.Mass:
                    lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
                    break;
                case TypeEnum.Temperature:
                    lstFrom.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    break;
                case TypeEnum.Time:
                    lstFrom.DataSource = Enum.GetValues(typeof(TimeEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TimeEnum));
                    break;
                default:
                    break;

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length <= 0)
                return;

            if(lstFrom.SelectedItem == lstTo.SelectedItem)
            {
                txtConvertedAmount.Text = txtAmount.Text;
            }

            var type = (TypeEnum)cmbType.SelectedItem;
            double amount = double.Parse(txtAmount.Text);
            double convertedAmount = 0;

            switch(type)
            {
                case TypeEnum.Mass:
                    var massFrom = (MassEnum)lstFrom.SelectedItem;
                    var massTo = (MassEnum)lstTo.SelectedItem;
                    convertedAmount = _converterService.ConvertMassUnit(massFrom, massTo, amount);
                    break;
                case TypeEnum.Temperature:
                    
                    convertedAmount = _converterService.ConvertTemperatureUnit((TemperatureEnum)lstFrom.SelectedItem, (TemperatureEnum)lstTo.SelectedItem, amount);
                    break;
                case TypeEnum.Time:
                    convertedAmount = _converterService.ConvertTimeUnit((TimeEnum)lstFrom.SelectedItem, (TimeEnum)lstTo.SelectedItem, amount);
                    break;
            }
            txtConvertedAmount.Text = convertedAmount.ToString();
    }
}
}