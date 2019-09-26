function checkvalue(event){
    var user = document.getElementById("user").value;
    var pass = document.getElementById("pass").value;
    var confirm = document.getElementById("confirm").value;
    var name = document.getElementById("name").value;
    var dob = document.getElementById("dob").value;
    var date = new Date;
    
    var day = date.getDate();
    var month = date.getMonth()+1;
    var year = date.getFullYear();
    
    var parts = dob.split("-");

    var choice1 = document.getElementById("english").checked;
    var choice2 = document.getElementById("nonenglish").checked;
   
    if((user.length<5 || user.length>12)){
        alert("user id must be between 5 and 12 characters");
        return false;
    }

    if(parts[0]>year){
        alert("enter a date before today");
        return false;
    }
    else if((parts[0]==year)&&(parts[1]>month)){
        alert("enter a date before today");
        return false;
    }
    else if((parts[0]==year)&&(parts[1]==month)&&(parts[2]>day)){
        alert("enter a date before today");
        return false;
    }

    if(year-parts[0]<18){
        alert("age should be greater than 18");
        return false;
    }
    else if((parts[1]>month)&&(year-parts[0]==18)){
        alert("age should be greater than 18");
        return false;
    }
    else if((parts[2]>day)&&(parts[1]==month)&&(year-parts[0]==18)){
        alert("age should be greater than 18");
        return false;
    }

    if((pass.length<5 || pass.length>12)){
        alert("password must be between 7 and 12 characters");
        return false;
    }

    if(pass != confirm){
        alert("password does not match");
        return false;
    }

    if(!name.match(/^[A-Za-z]+$/)){
        alert("name should contain only alphabets");
        return false;
    }

    if(choice1==""&&choice2==""){
        alert("select atleast one of the boxes in language");
        return false;
    }
}