<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DatePickerControl.ascx.cs" Inherits="PrestacaoContas.WebApp.Controles.DatePickerControl" %>
<asp:Label ID="lblDate" runat="server" Text="Data:"></asp:Label>
<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
<asp:Button ID="btnCalendario" runat="server" Text="..." 
    onclick="btnCalendario_Click" />
<div style="position:absolute;margin-left:30px"> 
<asp:Calendar ID="calCalendar" runat="server" 
    onselectionchanged="calCalendar_SelectionChanged" BackColor="White" 
    BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
    DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
    ForeColor="#003399" Height="200px" Width="220px" Visible="False">
    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
        Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
    <WeekendDayStyle BackColor="#CCCCFF" />
</asp:Calendar>
</div>
