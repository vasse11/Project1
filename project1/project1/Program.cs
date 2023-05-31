using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    { 
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();
        Thread.Sleep(2000);

        //identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("Hari");

        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        Loginbutton.Click();
        Thread.Sleep(1000);
        
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (helloHari.Text == "Hello hari!")

        {
            Console.WriteLine("user has logged in successfully");
        }
        else
        {
            Console.WriteLine("user has not logged");

        }
        // create new record

        //navigate to time and material page

        IWebElement adminstrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminstrationtab.Click();
        Thread.Sleep(2000);

        IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        tmoption.Click();


        // click on create  new button
        IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createnewbutton.Click();


        //select time from dropdown list
        IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        Typecodedropdown.Click();

        IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode-list\"]"));
        timeoption.Click();


        //input code
        IWebElement codetextbox = driver.FindElement(By.Id("Code"));
        codetextbox.SendKeys("may2023");

        //input description
        IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
        descriptiontextbox.SendKeys("May2023");

        //input price per unit
        IWebElement pricetextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        pricetextbox.SendKeys("12");

        //click on save button
        IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
        savebutton.Click();

        //check if new time record has been created successfully
        // go to last page
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();
        Thread.Sleep(2000);

        // Check if record is present in the table
        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "May2023")
        {
            Console.WriteLine("Time record created successfully.");
        }
        else
        {
            Console.WriteLine("Time record has not been created successfully.");
        }

    }
} 
       
   
     
    
  


    
