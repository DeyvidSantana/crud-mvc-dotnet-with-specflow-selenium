using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CrudMvcDotnet.Specs
{
    [Binding]
    public class CategoriaSteps
    {
        IWebDriver Browser;
        private readonly string url = "http://localhost:55745/";

        [BeforeScenario]
        public void Init()
        {
            Browser = new ChromeDriver();
        }

        [AfterScenario]
        public void Close()
        {
            Browser.Close();
            Browser.Dispose();
        }

        [Given(@"Um usuário acessou a tela inicial")]
        public void DadoUmUsuarioAcessouATelaInicial()
        {
            Browser.Navigate().GoToUrl(url);
        }
        
        [When(@"Clicar no botão Categorias")]
        public void QuandoClicarNoBotaoCategorias()
        {
            var btnCategorias = Browser.FindElement(By.Id("btnQueroMeCadastrar"));
            btnCategorias.Click();
        }
        
        [Then(@"Então a tela inicial de categoria deverá ser exibida com o botão Create New")]
        public void EntaoEntaoATelaInicialDeCategoriaDeveraSerExibidaComOBotaoCreateNew()
        {
            Browser.Navigate().GoToUrl($"{url}Categorias");

            try
            {
                var btnCreateNew = Browser.FindElement(By.Id("btnCreateNew"));
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
