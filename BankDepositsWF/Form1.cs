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
            // �������� ��������� ������
            if (!decimal.TryParse(textBoxInitialAmount.Text, out decimal initialAmount))
            {
                MessageBox.Show("������� ���������� ��������� �����.");
                return;
            }

            if (!decimal.TryParse(textBoxInterestRate.Text, out decimal interestRate))
            {
                MessageBox.Show("������� ���������� ���������� ������.");
                return;
            }

            int years = (int)numericUpDownYears.Value;

            // ������ �������� �����
            decimal finalAmount = CalculateFinalAmount(initialAmount, interestRate, years);

            // ����������� ����������
            labelResult.Text = $"�������� �����: {finalAmount:C}";
        }

        private decimal CalculateFinalAmount(decimal initialAmount, decimal interestRate, int years)
        {
            // ������� ��� ������� �������� ����� �� ������� ���������
            decimal finalAmount = initialAmount + (initialAmount * interestRate * years / 100);
            return finalAmount;
        }
    }
}