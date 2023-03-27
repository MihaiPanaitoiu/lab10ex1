using lab10ex1.Interfaces;

namespace lab10ex1.Devices
{        
        class Pos
        {
                public void Pay(IContactLessPayment card)
            {
                card.NearingDevice();
                card.Pay();
            }
                public void Pay(IContactFullPayment card)
            {
                card.InsertCard();
                card.Pay();
                card.ExtractCard();
            }
        }
}
