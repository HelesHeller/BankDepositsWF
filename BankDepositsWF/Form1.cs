namespace BankDepositsWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Проверка введенных данных
            if (!decimal.TryParse(textBoxInitialAmount.Text, out decimal initialAmount))
            {
                MessageBox.Show("Введите корректную начальную сумму.");
                return;
            }

            if (!decimal.TryParse(textBoxInterestRate.Text, out decimal interestRate))
            {
                MessageBox.Show("Введите корректную процентную ставку.");
                return;
            }

            int years = (int)numericUpDownYears.Value;

            // Расчет конечной суммы
            decimal finalAmount = CalculateFinalAmount(initialAmount, interestRate, years);

            // Отображение результата
            labelResult.Text = $"Конечная сумма: {finalAmount:C}";
        }

        private decimal CalculateFinalAmount(decimal initialAmount, decimal interestRate, int years)
        {
            // Формула для расчета конечной суммы по простым процентам
            decimal finalAmount = initialAmount + (initialAmount * interestRate * years / 100);
            return finalAmount;
        }
    }
}