# Desafio-Programacao

Caso o Projeto aberto no Visual Studio, de um duplo click no Database encontrado na pasta App_Data do View, copiando o **Caminho da Conexão**
em propriedade colando na Classe Conexao localizado no Repository.
Para realizar a execução basta selecionaro arquivo View localizano local a seguir *Desafio-Programacao\Desafio\View\bin\Debug* ou precionando 
o botão F5 no Visual Studio.

***Tela Principal***
   A tela dispoem de duas opções, sendo elas: Cadastro e Consulta. Cada uma com subseções sendo as de Cadastro: Pessoa, Sala de Evento, Espaço
de Café, Pessoa por Evento e Pessoa por Espaço; as opções de Consulta são: Pessoa, Sala de Evento e a de Espaço de Café.

***Tela de Cadastro/Edição de Pessoa***
   A tela dispoem de um botão para *Salvar* que tem dupla funcionalidade, ele serve tanto para fazer o Cadastro de uma nova pessoa quanto para fazer a 
Edição de uma pessoa. Antes de poder fazer a edição de uma pessoa deve-se dar um duplo click no registro a ser editado. O que faz com que o botão de 
salvar saiba se é para fazer a edição o o encremento de um novo registro é o campo ID que fica invisivel na tela, que caso o ID esteja como 0 sera feito 
o incremento de um novo registro caso seja diferente de 0 sera feita a edição do registro selecionado. A tela dispoem também de um botão para *Desativar* 
uma pessoa, que fara com que o registro não seja mais mostrado na lista de Pessoas pórem ainda estara guardada no banco de dados.
A tela possui um campo para informar a data de nascimento e outra para informar o nome da mãe pois caso haja duas pessoas com o mesmo nome pode ser feita
a checagem pelo nome da mãe.

***Tela de Cadastro/Edição de Sala de Evento***   
   A tela dispoem de um botão para *Salvar* que tem dupla funcionalidade, ele serve tanto para fazer o Cadastro de uma nova sala de evento quanto para 
fazer a Edição de uma sala. Para que se possa fazer a edição de uma das salas é necessario primeiro selecionar o registro a ser editado na tabela dando 
um duplo click sobre o registro desejado. A ação que faz com que o botão *Salvar* diferencie se o evento deve ser de Alterar ou de Inserir é o label do 
Id que, caso seja igual a 0, o botão identifica que deve ser incrementada uma nova sala; caso seja diferente de 0 ele fara a alteração de uma sala.
A tela dispoem também de um botão para *Desativar* uma sala de eventos, que fara com que o registro não seja mais mostrado na lista de Salas, pórem ainda 
estara guardada no banco de dados.

***Tela de Cadastro/Edição de Espaço de Café***
   A tela dispoem de um botão para *Salvar* que tem dupla funcionalidade, ele serve tanto para fazer o Cadastro de um novo espaço de café quanto para 
fazer a Edição de um espaço. Para que se possa fazer a edição de um dos espaços é necessario primeiro selecionar o registro a ser editado na tabela dando 
um duplo click sobre o registro desejado. A ação que faz com que o botão *Salvar* diferencie se o evento deve ser de Alterar ou de Inserir é o label do 
Id que, caso seja igual a 0, o botão identifica que deve ser incrementada um novo espaço; caso seja diferente de 0 ele fara a alteração de um espaço.
A tela dispoem também de um botão para *Desativar* um espaço de café, que fara com que o registro não seja mais mostrado na lista de Salas, pórem ainda 
estara guardada no banco de dados.

***Tela de Cadastro/Edição de Pessoa por Evento***
   A tela dispoem de um botão para *Salvar* que possui uma dupla funcionalidade, caso o campo invisivel do Id seja 0 o botão tera a função de Inserir um pessoa 
no evento caso a lotação máxima do evento não tenha sido atingida; caso o Id seja direfente de 0 o botão tera a função de alterar, que para está ser ativada deve-se 
dar um duplo click no registro a ser editado. A tela tambem dispoem de um botão *Desativar* que fara com que o registro não seja seja mais mostrado na tela 
mas continue guardado no banco de dados. 

***Tela de Cadastro/Edição de Pessoa por Espaço***
   A tela dispoem de um botão para *Salvar* que possui uma dupla funcionalidade, caso o campo invisivel do Id seja 0 o botão tera a função de Inserir um pessoa 
no espaço caso a lotação máxima do espaço ainda não tenha sido atingida; caso o Id seja direfente de 0 o botão tera a função de alterar, que para está ser 
ativada deve-se dar um duplo click no registro a ser editado. A tela tambem dispoem de um botão *Desativar* que fara com que o registro não seja seja mais 
mostrado na tela mas continue guardado no banco de dados. 

***Consulta de Pessoas***
   A tela possui um compo de texto para que possa ser feita a pesquisa a partir do nome da Pessoa; a tabela com todos os registro se atualiza automaticamente
conforme o campo de busca é preenchido, caso ao se pesquisar seja deixado o campo com "espaço" o programa não realiza a busca. Ao se deixar o campo de busca vazio 
a tabela mostra o registro de todas as pessoas cadastradas no banco que estiverem ativas.

***Consulta de Sala de Evento***
   A tela possui um ComboBox com a lista de todos as Salas para que possa ser feita a pesquisa a partir do nome da Sala de Evento; a tabela com todos os registro 
se atualiza automaticamente após ser selecionada a sala a ser consultada.

***Consulta de Espaço de Café***
   A tela possui um ComboBox com uma lista de todos os espaços para que possa ser feita a pesquisa a partir do nome do Espaço de Café; a tabela com todos os 
registro se atualiza automaticamente após a seleção do espaço desejado.

***Consulta de Pessoa por Evento***
   A tela possui um ComboBox com uma lista de todas as pessoas para que possa ser feita a pesquisa a partir do nome da Pessoa; a tabela com todos os 
registro se atualiza automaticamente após a seleção da pessoa desejado, que mostrara na tabela a sala em que a pessoa se encontrava na primeira etapa e a sala em 
que a pessoa se encontra na segunda etapa.

***Troca de Sala***
    A tela de troca de sala possui dois ComboBox que possuem todos os eventos cadastrados, ao selecionar um evento diferente para ambos, sera carrega as 
pessoas que estão em cada evento;
Ao precionar o botão *Trocar*, o mesmo ira checar qual dos dois evento possui o menor numero de pessoas cadastradas e o dividira pela metada para que então 
seja realizada a troca. Antes de ser realizada a troca também é checado se existe alguma pessoa cadastrada no evento, caso não tenha nenhum cadastrado é 
mostrada uma mensagem de aviso para que se selecione um evento com pessoas cadastradas.
