namespace lab10ex1.Interfaces
{
        interface IContactFullPayment : IPosPayment
        {
            void InsertCard();
            void ExtractCard();
        }
}
