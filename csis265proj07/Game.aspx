<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="csis265proj07.Game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="lblInstruction1" runat="server" Text="Guess a Random Number Within 7 Tries"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblInstruction2" runat="server" Text="Enter your guess:  "></asp:Label>
        <asp:TextBox ID="txtGuessInput" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblInputResponse" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnNewGame" runat="server" OnClick="btnNewGame_Click" Text="NewGame" />
        <asp:Button ID="btnSubmitGuess" runat="server" OnClick="btnSubmitGuess_Click" Text="SubmitGuess" />
    </p>
</asp:Content>
