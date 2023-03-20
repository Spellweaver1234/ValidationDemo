using FluentValidation;

using ModelLibrary;

namespace FluentValidationDemo.Validators
{
    public class PersonValidator: AbstractValidator<PersonModel>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(p => p.SecondName)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(p => p.DateOfBirth)
                .Must(BeAValidAge).WithMessage("Invalid {PropertyName}");
        }

        // дата рождения: не старше 120 лет и не младше текущего года
        private bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if (dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }

        private bool BeAValidName(string name)
        {
            name = name.Replace(" ","");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }
    }
}
