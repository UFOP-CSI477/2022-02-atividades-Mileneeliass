using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Sistema_de_doacao_de_sangue.Models;
using Sistema_de_doacao_de_sangue.Repositorio;

namespace Sistema_de_doacao_de_sangue.Controllers
{
    public class DoacaoController : Controller
    {
        private readonly IDoacaoRepositorio _doacaoRepositorio;

        public DoacaoController(IDoacaoRepositorio doacaoRepositorio)
        {
            _doacaoRepositorio = doacaoRepositorio;
        }
        public IActionResult Index()
        {
            List<DoacaoModel> doacoes = _doacaoRepositorio.BuscarTodos();
            return View(doacoes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
           DoacaoModel doacao = _doacaoRepositorio.ListarPorId(id);
            return View(doacao);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            DoacaoModel doacao = _doacaoRepositorio.ListarPorId(id);

            return View(doacao);
        }

        public IActionResult Apagar(int id)
        {
            try
            {

                bool  apagado =_doacaoRepositorio.Apagar(id);
                if(apagado)
                {
                    TempData["MensagemSucesso"] = "Cadastro apagado com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Não foi possível apagar o cadastro";

                }
                return RedirectToAction("Index");

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = "Não foi possível apagar o cadastro";
                return RedirectToAction("Index");
            }


        }


        [HttpPost]
        public IActionResult Criar(DoacaoModel doacao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _doacaoRepositorio.Adicionar(doacao);
                    TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";
                return RedirectToAction("Index");
                }
                return View(doacao);

            }
            catch(System.Exception erro)
            {
                TempData["MensagemErro"] = "Não foi possível realizar o cadastro";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(DoacaoModel doacao)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _doacaoRepositorio.Atualizar(doacao);
                    TempData["MensagemSucesso"] = "Alteração realizada com sucesso!";
                    return RedirectToAction("Index");
             
                }
                return View(doacao);

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = "Não foi possível realizar a alteracao";
                return View("Editar", doacao);
            }
      
        }

    }
}
