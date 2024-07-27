using  SimpleAPI.Controllers;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController = new ValuesController();     //Arrange
   
    [Fact]
    public void GetReturnedCollectNumber()
    {
        var getValue = valuesController.Get(1);                     //Act
       
        Assert.Equal("pradeep kumar", getValue);                        //Assert
    }
    
    public string GetName()
    {
        return "pradeep kumar";
    }
}   