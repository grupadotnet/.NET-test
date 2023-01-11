
namespace ACM.BL.Test
{
    
    public class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }

        [Test]
        public void FindExistingCustomer()
        {
            // Arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            // Act
            var result = repository.Find(customerList, 4);

            // Assert
           
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.CustomerId);
            Assert.AreEqual("Solo", result.LastName);
            Assert.AreEqual("Han", result.FirstName);
        }




        //Zadanie 1
        // Napisz test jednostkowy sprawdzadzj¹cy dzia³anie naszej funckji "SortByName" zadeklarowanej w "CharactersRepository".


        //Zadanie 2
        // Napisz test jednostkowy sprawdzadzj¹cy dzia³anie naszej funckji "SortByNameInReverse" zadeklarowanej w "CharactersRepository".


        //Zadanie 3
        // Napisz test jednostkowy sprawdzadzj¹cy dzia³anie naszej funckji "SortByType" zadeklarowanej w "CharactersRepository".

        

    }
}
