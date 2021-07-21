// for calling function of Calculate
window.onload=()=>{
  
document.querySelector('#btn_calculate').onclick=Calculate;
}


// calculation of tip amount
function Calculate(){
    
    var amt=document.querySelector('#txtbillamt').value;
    var people=document.querySelector('#txtnumber').value;
    var service=document.querySelector('#selservice').value;

    var totaltip=(amt * service)/people;
    
    document.querySelector('#totalbill').innerHTML=totaltip;
    document.querySelector('#txt_tipamt').value= document.querySelector('#totalbill').innerHTML;
    document.querySelector('#totalbill').style.display='none';
}

