using propsMetEConstructor.models;

Pessoa P1 = new Pessoa(nome:"Gustavo",sobrenome: "Medeiros");

Pessoa P2 = new Pessoa(nome:"Rafael",sobrenome: "Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(P1);
cursoDeIngles.AdicionarAluno(P2);
cursoDeIngles.ListarAlunos();
