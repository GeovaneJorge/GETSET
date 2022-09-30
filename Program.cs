using Explorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome="Geovane";
// p1.Idade= 30;
// p1.Apresentar();

Pessoa p1 = new Pessoa("Geovane");
Pessoa p2 = new Pessoa("Iron");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome="Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

