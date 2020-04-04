$(document).ready(function() {


   $("#arrival_date").focus();

   var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;


   $("#submit").click(function(){

        if($("#arrival_date").val()=="")
        {
            $("#arrival_dateError").text("Enter arrival date");
            return false;
        }

        else if($("#nights").val()=="")
        {
            $("#nightsError").text("Enter nights");
            return false;
        }

        else if(isNaN($("#nights").val()))
        {
            $("#nightsError").text("The number of nights must be numeric.");
            return false;
        }

        else if($("#name").val()=="")
        {
            $("#nameError").text("Enter name");
            return false;
        }

        else if($("#email").val()=="")
        {
            $("#emailError").text("Enter email");
            return false;
        }

        else if(!emailPattern.test($("#email").val()))

        {
            $("#emailError").text("must be the pattern that’s provided.");
            return false;
        }

        else if($("#phone").val()=="")

        {
            $("#phoneError").text("Enter phone");
            return false;
        }

        else{
            return true;
        }

   });

});

