namespace Canteen.Common
{
    using System;

    public static class Constants
    {
        public const double WrapperSizeCoefficient = 0.9;
        public const string InvalidLoginDataMessage = "Не са открити данни за потребителя. Моля опитайте отново!";
        public const string RequiredUsernameMessage = "Моля въведете потребителско име!";
        public const string RequiredFirstNameMessage = "Моля въведете първо име!";
        public const string RequiredLastNameMessage = "Моля въведете фамилия!";
        public const string RequiredPasswordMessage = "Моля въведете парола!";
        public const string UsernameTakenMessage = "Потребителското име вече съществува. Моля въведете отново!";
        public const string SuccessfulRegisterMessage = "Успешна регистрация";
        public const string AboutInformation =
            "Разработил: {0}{5}Факултетен номер: {1}{5}Специалнос: {2}{5}Поток: {3}{5}Група: {4}{5}";
    }
}
