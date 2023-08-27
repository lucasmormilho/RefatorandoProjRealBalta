using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValuesObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://balta.io";

        [TestMethod("Deve retornar uma exceção quando URL for inválida")]
        [TestCategory("Teste de URL")]
        [ExpectedException(typeof(InvalidUrlException))]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            //usar o [ExpectedException(typeof(InvalidUrlException))]
            new Url(InvalidUrl);
        }

        [TestMethod("Não deve retornar uma exceção quando URL for válida")]
        [TestCategory("Teste de URL")]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true); // assegura que é true
        }


        [TestMethod("Usando Datarow teste")]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow("banana", true)]
        [DataRow("https://balta.io", false)]
        public void TesteUrl(string link, bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException e)
                {
                    Assert.IsTrue(true);
                }
            }
        }
    }
}
