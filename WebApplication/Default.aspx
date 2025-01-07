<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Conteudo" runat="server">
    <!-- Place somewhere in the <body> of your page -->
    <div class="content-wrap-corpo">
        <div>
            <h1 class="titulo-sobre">O PASSADO DA PROGRAMAÇÃO</h1>
        </div>
        <div class="container">
            <div>
                <p class="text">
                    Os Primeiros Passos: Século XIX
A jornada da programação começou no século XIX com Ada Lovelace, uma matemática britânica que é considerada a primeira programadora. Ela escreveu notas sobre a máquina analítica de Charles Babbage, um dos primeiros conceitos de um computador mecânico. Em suas anotações, Lovelace descreveu um algoritmo para calcular os números de Bernoulli, o que é frequentemente visto como o primeiro programa de computador.
                </p>
            </div>
            <div class="image">
                <img class="image2" src="../Images/progama1.jpg" />
            </div>
        </div>
        <div class="container">
            <p class="text">
                O Século XX e a Consolidação
O século XX trouxe uma série de inovações cruciais. Durante a Segunda Guerra Mundial, o desenvolvimento do ENIAC (Electronic Numerical Integrator and Computer) marcou um avanço significativo na computação. Programar o ENIAC envolvia um processo complexo de conectar fios e configurar interruptores, um método que evoluiria para linguagens de programação mais sofisticadas.

Na década de 1950, surgiram as primeiras linguagens de programação de alto nível. Fortran (Formula Translation), criado por IBM, foi projetado para facilitar cálculos científicos e engenheiros. Seguiram-se outras linguagens como COBOL (Common Business-Oriented Language), voltada para aplicações comerciais, e LISP (LISt Processing), usada em inteligência artificial. Estas linguagens representaram uma mudança crucial do código de máquina para uma forma mais compreensível e eficiente.
            </p>
        </div>
        <div class="container">
            <div class="image">
                <img class="image2" src="../Images/progama2.jpg" />
            </div>
            <div>
                <p class="text">
                    Nos anos 1980, a programação orientada a objetos ganhou destaque com o surgimento do C++, uma extensão da linguagem C desenvolvida por Bjarne Stroustrup. O C++ introduziu conceitos que permitiram uma abordagem mais modular e reutilizável na programação. Em 1991, Guido van Rossum lançou o Python, uma linguagem de programação de alto nível que se destacou pela sua simplicidade e versatilidade, rapidamente se tornando popular em uma ampla gama de aplicações, desde desenvolvimento web até análise de dados.
                </p>
            </div>
        </div>
    </div>

    <br id="lingprog" />

    <div>
        <h1 class="titulo-sobre">SOBRE AS LINGUAGENS DE PROGRAMAÇÃO
        </h1>
    </div>

    <div class="row margin-top-60">
        <div class="col-3">
            <div class="box padding-14 border margin-right-20">
                <img width="50%" src="../Images/linguagem%20c.png" />
                <br />
                <div class="padding-14">
                    <h3>
                        <a href="https://learn.microsoft.com/pt-br/cpp/c-language/?view=msvc-170" target="_blank">LINGUAGEM C</a>
                    </h3>
                    <br />
                    <p>
                        Desenvolvida por Dennis Ritchie nos anos 1970, a linguagem C é conhecida por sua eficiência e controle direto sobre hardware, sendo fundamental no desenvolvimento do sistema Unix. Sua sintaxe simples e poderosa influenciou muitas linguagens modernas, como C++ e Java, e é amplamente usada em sistemas, aplicativos e software embarcado.
                    </p>
                </div>
            </div>
        </div>

        <div class="col-3">
            <div class="box padding-14 border margin-right-20">
                <img width="90%" src="../Images/java.png" />
                <br />
                <div class="padding-14">
                    <h3>
                        <a href="https://www.java.com/pt-BR/" target="_blank">JAVA</a>
                    </h3>
                    <br />
                    <p>
                        Criada por James Gosling em 1995, Java é uma linguagem orientada a objetos que permite a execução de programas em qualquer plataforma através da Java Virtual Machine (JVM). Conhecida por sua portabilidade e robustez, é amplamente utilizada no desenvolvimento de aplicativos web e móveis, especialmente para Android.
                    </p>
                </div>
            </div>
        </div>

        <div class="col-3">
            <div class="box padding-14 border margin-right-20">
                <img width="50%" src="../Images/python.png" />
                <br />
                <div class="padding-14">
                    <h3>
                        <a href="https://www.python.org/" target="_blank">PYTHON</a>
                    </h3>
                    <br />
                    <p>
                        Lançado em 1991 por Guido van Rossum, Python é uma linguagem de alto nível famosa por sua sintaxe clara e legível. Versátil e poderosa, é usada em desenvolvimento web, automação e ciência de dados, e sua simplicidade e vasto ecossistema de bibliotecas a tornam popular entre desenvolvedores e pesquisadores.
                    </p>
                </div>
            </div>
        </div>

        <div class="col-3">
            <div class="box padding-14 border margin-right-20">
                <img width="50%" src="../Images/cobol.png" />
                <br />
                <div class="padding-14">
                    <h3>
                        <a href="https://www.ibm.com/br-pt/topics/cobol" target="_blank">COBOL</a>
                    </h3>
                    <br />
                    <p>
                        Desenvolvido por Grace Hopper nos anos 1950, COBOL é uma das linguagens mais antigas, projetada para processamento de dados comerciais com uma sintaxe próxima ao inglês. Ainda amplamente usado em sistemas legados no setor financeiro e governamental, COBOL é conhecido por sua confiabilidade em ambientes críticos.
                    </p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
