namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1 
            //Book book1=new Book();
            //book1.genre = Genre.Science;
            //Console.WriteLine(book1.genre);

            #endregion

            #region question2
            //Console.WriteLine((int)Genre.Fiction);    
            //Console.WriteLine((int)Genre.NonFiction); 
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region question3 
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);

            #endregion
            #region question4 
            //string genreText = "Science";
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genre);
            #endregion

            #region question5
            //string genreText = "Mystery";
            //Book book1=new Book();
            //bool isvalid=Enum.TryParse(genreText, true, out book1.genre);
            //if (isvalid) { Console.WriteLine("known"); }
            //else { Console.WriteLine("unknown"); }


            #endregion

            #region question6
            //DeliveryAddress original = new DeliveryAddress("Cairo", "Tahrir St", 10);
            //DeliveryAddress copy = original;
            //copy.city = "Giza";
            //copy.street = "Pyramids Rd";
            //copy.BuildingNumber = 25;
            //Console.WriteLine("Original: " + original.GetFullAddress());
            //Console.WriteLine("Copy: " + copy.GetFullAddress());
            #endregion
        }
    }
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {street}, {city}";
        }
    }
    public struct  Shipment
    {
        private string TrackingCode;
        private string Description;
        private int Weight;
        private int DeliveryFee;
        public DeliveryAddress Destination;

        public Shipment(string trackingCode, string description, int weight, int deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public void setWeight(int weight)
        {
            if (weight > 0) { this.Weight= weight; }
        }
        public int getWeight() { return this.Weight; }
        public void setDeliveryFee(int deliveryFee)
        {
            if (deliveryFee > 0) { this.DeliveryFee = deliveryFee; }
        }
        public int getDeliveryFee() { return this.DeliveryFee; }
        public void setTrackingCode(string trackingCode)
        {
            if(trackingCode!=null)
            {
                this.TrackingCode = trackingCode;
            }
        }
        public string getTrachingCode() { return this.TrackingCode; }
        public string getDescription() { return this.Description; }
        public void setDescription(string description)
        {
            if (description != null)
            {
                this.Description = description;
            }
        }
        public int EstimatedCost()
        {
            return DeliveryFee + (Weight * 5);
        }
        public Shipment(string trackingCode)
        {
            this.TrackingCode= trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public void UpdateDeliveryFee(int newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine($"tracking code:{TrackingCode},,,,description:{Description},,,,weight:{Weight},,,,delivery fee:{DeliveryFee}");
        }



    }


}
