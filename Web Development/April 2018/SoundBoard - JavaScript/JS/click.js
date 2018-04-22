//Select an element

const selection1 = document.getElementById('americangif');
const selection2 = document.getElementById('asifgif');
const selection3 = document.getElementById('fetchgif');
const selection4 = document.getElementById('orangegif');
const selection5 = document.getElementById('pinkgif');
const selection6 = document.getElementById('pslgif');
const selection7 = document.getElementById('richgif');
const selection8 = document.getElementById('whatevergif');


selection1.addEventListener('click',  function () {

    const sound = document.querySelector('#americans');
    setTimeout(function(){
      sound.play();
    }, 0);
});
selection2.addEventListener('click',  function () {
    
        const sound = document.querySelector('#asif');
        setTimeout(function(){
          sound.play();
        }, 0);
});
selection3.addEventListener('click',  function () {
    
        const sound = document.querySelector('#fetch');
        setTimeout(function(){
          sound.play();
        }, 0);
    });
selection4.addEventListener('click',  function () {
        
            const sound = document.querySelector('#orange');
            setTimeout(function(){
              sound.play();
            }, 0);
});
selection5.addEventListener('click',  function () {
            
    const sound = document.querySelector('#pink');
    setTimeout(function(){
    sound.play();
    }, 0);
});
selection6.addEventListener('click',  function () {
                
    const sound = document.querySelector('#psl');
    setTimeout(function(){
    sound.play();
    }, 0);
});
selection7.addEventListener('click',  function () {
                    
        const sound = document.querySelector('#rich');
        setTimeout(function(){
        sound.play();
        }, 0);
});
selection8.addEventListener('click',  function () {
                        
    const sound = document.querySelector('#whatever');
        setTimeout(function(){
        sound.play();
        }, 0);
});


//Listen to the click 
// function sound1(){
//     var audio = document.getElementById('americans');
//     audio.play();

// }
// function sound2(){
//     var audio = document.getElementById('asif');
//     audio.play();

// }
// function sound3(){
//     var audio = document.getElementById('fetch');
//     audio.play();

// }
// function sound4(){
//     var audio = document.getElementById('orange');
//     audio.play();

// }
// function sound5(){
//     var audio = document.getElementById('pink');
//     audio.play();

// }
// function sound6(){
//     var audio = document.getElementById('psl');
//     audio.play();

// }
// function sound7(){
//     var audio = document.getElementById('rich');
//     audio.play();

// }
// function sound8(){
//     var audio = document.getElementById('whatever');
//     audio.play();

// }




// console.log(selection2);
// selection2.addEventListener('click', function (){
//     console.info('here');
// });