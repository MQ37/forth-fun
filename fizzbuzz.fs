: fizz? 3 mod 0 = dup ( n -- b )
    if
        ." Fizz"
    endif ;
: buzz? 5 mod 0 = dup ( n -- b )
    if
        ." Buzz"
    endif ;

: main cr 31 1 do ( fizz buzz )
    i fizz?
    i buzz?
    or invert
    if
        i .
    endif cr loop ;
