using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext contexto = new SistemaContext();

            #region inserir 
            //Animal animal = new Animal();
            //animal.Nome = "ROdolfo abigail";
            //animal.Extinto = false;
            //animal.dataCriacao = DateTime.Now;


            //contexto.Animais.Add(animal);
            //contexto.SaveChanges();
            //Console.WriteLine("Registro Salvo em:" + DateTime.Now);
            #endregion inserir

            #region alterar
            //var rodolfo = contexto.Animais.First(x => x.id == 4);

            //rodolfo.Nome = "Javali preto";
            //contexto.SaveChanges();
            #endregion altwrar

            #region apagar
            //Animal animalApagar = contexto.Animais.Where(x => x.Nome == "Billy Jonas de Umberto").First();
            //contexto.Animais.Remove(animalApagar);
            //contexto.SaveChanges();
            #endregion apagar

            #region listar
            //List<Animal> animais = contexto.Animais/*.Where(x => x.Extinto == false && x.Nome.Contains("a"))*/.OrderBy(x => x.Nome).ToList();
            //foreach (Animal animal in animais)
            //{
            //    Console.WriteLine($"{animal.id}-{animal.Nome}-{animal.Extinto}-{animal.dataCriacao}");
            //}
            #endregion listar

            #region InserirRelacionameno
            Habilidade habilidade = new Habilidade();
            habilidade.IdAnimal = 1;
            habilidade.Nome = "Invisivel";

            contexto.Habilidades.Add(habilidade);
            contexto.SaveChanges();
            Console.WriteLine("Salvo com Sucesso");
            #endregion InserirRelacionamento

            var habilidades = contexto.Habilidades.ToList();

            foreach (Habilidade habilidadeAux in habilidades)
            {
                Console.WriteLine(habilidade.Nome);
                habilidadeAux.Animal.Nome + " - " + habilidadeAux.Nome);
            }
        }
    }
}
