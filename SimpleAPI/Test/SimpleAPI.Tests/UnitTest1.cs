using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    valueController valueController=new valueController() ;
    [Fact]
    public void Test1()
    {
      
    }
    [Fact]
    public void GetReturnedCollectNumber()
    {
        
        //given
        var getvalue=valueController.Get(1);   //act
        //when 
        
        //then
         Assert.Equal("pradeep",getvalue);


    }
}