var x = document.getElementById('p1');
var createform = document.createElement('form');
createform.setAttribute("method","post");
createform.setAttribute("action","");
createform.style.width = "220px";
createform.style.margin = "0 auto";
x.appendChild(createform);

var title = document.createElement('label');
title.innerHTML = "CREATE ACCOUNT";
title.style.fontWeight = "bold";
title.style.fontSize = "20px";
title.style.marginTop = "20px";
title.style.margin = "10px 15px";
createform.appendChild(title);

var bl = document.createElement('br');
createform.appendChild(bl);

var div = document.createElement('div');
div.className = 'form-group';
createform.appendChild(div);

var userlabel = document.createElement('label');
userlabel.innerHTML = "Username:";
userlabel.style.fontWeight = "bold";
div.appendChild(userlabel);

var username = document.createElement('input');
var query = document.querySelector('username');
username.type = 'text';
username.className = 'form-control';
username.required = true;
username.placeholder = "Enter your username";
username.style.width = "200px";
div.appendChild(username);

var div = document.createElement('div');
div.className = 'form-group';
createform.appendChild(div);

var passlabel = document.createElement('label');
passlabel.innerHTML = "Password:"
passlabel.style.fontWeight = "bold";
div.appendChild(passlabel);

var password = document.createElement('input');
password.type = 'password';
password.required = true;
password.placeholder = "Enter your password";
password.pattern = "(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}";
password.className = 'form-control';
password.style.width = "200px";
div.appendChild(password);

var text = document.createElement('p');
text.innerHTML = "*must be atleast 8 characters long<br>*must have an upper case, a lower case and a digit";
text.style.fontSize = "12px";
div.appendChild(text);

var div = document.createElement('div');
div.className = 'form-group';
createform.appendChild(div);

var passlabel = document.createElement('label');
passlabel.innerHTML = "Confirm Password:"
passlabel.style.fontWeight = "bold";
div.appendChild(passlabel);

var password = document.createElement('input');
password.type = 'password';
password.pattern = "(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}";
password.placeholder = "Re-enter your password";
password.required = true;
password.className = 'form-control';
password.style.width = "200px";
div.appendChild(password);

var type = document.createElement('label');
type.innerText = "Account type:"
type.style.fontWeight = "bold";
createform.appendChild(type);

var bl = document.createElement('br');
createform.appendChild(bl);

var accountlabel = document.createElement('label');
accountlabel.innerText = "Private:";
accountlabel.style.marginLeft = "20px";
createform.appendChild(accountlabel);

var account = document.createElement('input');
account.type = 'radio';
account.name = "type";
account.id = "radio1";
account.required = true;
account.style.marginLeft = "5px";
accountlabel.appendChild(account);



var accountlabel = document.createElement('label');
accountlabel.innerText = "Public:";
accountlabel.style.marginLeft = "20px";
createform.appendChild(accountlabel);

var account = document.createElement('input');
account.type = 'radio';
account.name = "type";
account.id = "radio2";
account.required = true;
account.style.marginLeft = "5px";
accountlabel.appendChild(account);

var bl = document.createElement('br');
createform.appendChild(bl);

var type = document.createElement('label');
type.innerText = "Gender:";
type.style.fontWeight = "bold";
createform.appendChild(type);

var bl = document.createElement('br');
createform.appendChild(bl);

var malelabel = document.createElement('label');
malelabel.innerText = "Male:";
malelabel.style.marginLeft = "20px";
createform.appendChild(malelabel);

var male = document.createElement('input');
male.type = 'radio';
male.name = "gender";
male.id = "male";
male.required = true;
male.style.marginLeft = "5px";
malelabel.appendChild(male);

var femalelabel = document.createElement('label');
femalelabel.innerText = "Female:";
femalelabel.style.marginLeft = "33px";
createform.appendChild(femalelabel);

var female = document.createElement('input');
female.type = 'radio';
female.name = "gender";
female.id = "female";
female.required = true;
female.style.marginLeft = "5px";
femalelabel.appendChild(female);

var submit = document.createElement('input');
submit.type='submit';
submit.style.width = "100px";
submit.style.margin = "10px 50px";
submit.innerHTML = 'submit';
submit.className = 'btn btn-primary';
createform.appendChild(submit);