// Sistema de gestão escolar com classes para Aluno, Professor e Disciplina.  
// Permite armazenar informações de alunos, professores e disciplinas,  
// incluindo notas, matérias lecionadas e alunos matriculados.  
Aluno aluno = new();
Professor professor = new();
Disciplina disciplina = new();

aluno.Nome = "Carlos Silva";
aluno.Idade = 16;
aluno.Notas = [8.5, 7.0, 9.2];

disciplina.NomeDisciplina = "Matemática";
disciplina.AlunosMatriculados = [aluno];

professor.Nome = "Marcos Oliveira";
professor.DisciplinasLecionadas = [disciplina.NomeDisciplina];

Console.WriteLine("Aluno:");
Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine($"Notas: {string.Join(" - ", aluno.Notas)}");

Console.WriteLine("\nDisciplina:");
Console.WriteLine($"Nome: {disciplina.NomeDisciplina}");
Console.WriteLine($"Alunos matrículados: {string.Join(", ", disciplina.AlunosMatriculados.Select(a => a.Nome))}");

Console.WriteLine("\nProfessor:");
Console.WriteLine($"Nome: {professor.Nome}");
Console.WriteLine($"Disciplinas lecionadas: {string.Join(", ", professor.DisciplinasLecionadas)}");

