using Exemplo_Escola;

Professor professor1 = new Professor("Jose","Artes",2500,new DateTime(2001,03,25));
Aluno aluno1 = new Aluno(1,"Lucas Moura","25/03/2002","225.665.888-44","Ativo",professor1);

Professor professor2 = new Professor("Mario", "EDF", 2500, new DateTime(2010, 03, 25));
Aluno aluno2 = new Aluno(2, "Lucas Silva", "24/05/2006", "225.665.888-45", "Ativo", professor2);


Professor professor3 = new Professor("Carlos", "Fisica", 1899, new DateTime(2001, 03, 25));
Aluno aluno3 = new Aluno(3, "Fernando", "25/03/2007", "225.665.888-46", "Ativo", professor3);


Professor professor4 = new Professor("Marlon", "Geografia", 3600, new DateTime(2001, 03, 25));
Aluno aluno4 = new Aluno(4, "Mauricio Costa", "17/03/2002", "225.665.888-50", "Ativo", professor4);


Professor professor5 = new Professor("Silva", "Ortografia", 4000, new DateTime(2001, 03, 25));
Aluno aluno5 = new Aluno(1, "Lucio Moura", "26/03/2002", "225.665.896-44", "Ativo", professor5);
Console.WriteLine(aluno3.Professor);

Console.WriteLine(String.Compare("123", "1234"));