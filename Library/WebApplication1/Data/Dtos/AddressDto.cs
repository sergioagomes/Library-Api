namespace Library.Data.Dtos
{
    public class AddressDto
    {
        public class CreateAddressDto
        {
            public string Name { get; set; }
            public int Number { get; set; }
        }

        public class ReadAddressDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Number { get; set; }
        }

        public class UpdateAddressDto
        {
            public string Name { get; set; }
            public int Number { get; set; }
        }

    }
}
