#language: pt-br

Funcionalidade: Categoria
	Como um usuário
	Desejo acessar a tela de categorias
	Assim posso inserir, editar e excluir categorias


Cenário: 1) Quando o usuário acessar a página de categoria, deverá existir um botão para criar uma nova categoria
	Dado Um usuário acessou a tela inicial
	Quando Clicar no botão Categorias
	Então Então a tela inicial de categoria deverá ser exibida com o botão Create New