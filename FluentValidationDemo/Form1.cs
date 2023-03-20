using System.ComponentModel;

using FluentValidation.Results;

using FluentValidationDemo.Validators;

using ModelLibrary;

namespace FluentValidationDemo
{
    public partial class Form1 : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();

            errorListBox.DataSource = errors;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errors.Clear();

            if (!decimal.TryParse(abTextBox.Text, out decimal accountBalance))
            {
                errors.Add("Account balance: Invalid Amount");
                return;
            }

            PersonModel person = new PersonModel();
            person.FirstName = fnTextBox.Text;
            person.SecondName = snTextBox.Text;
            person.AccountBalance = accountBalance;
            person.DateOfBirth = dateTimePicker.Value;

            // Validation
            PersonValidator validator = new PersonValidator();
            ValidationResult result = validator.Validate(person);

            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    errors.Add(failure.ErrorMessage);
                }
            }

            // Insert into Database
            // ...

            MessageBox.Show("Done");
        }
    }
}