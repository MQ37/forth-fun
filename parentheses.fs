: validate ( addr l -- b )
    { addr l }
    0
    l 0 do 

        addr I chars + c@ \ get char at index
        dup 40 = if \ if ( increment
            swap 1+ swap
        endif

        dup 41 = if \ if ) decrement
            swap 1- swap
        endif

        drop

        dup 0 < if \ if negative not valid
            false unloop exit
        endif
    loop
    0= \ return boolean
    ;

." () is valid: " s" ()" validate . cr
." ()) is valid: " s" ())" validate . cr
." ())( is valid: " s" ())(" validate . cr
." (() is valid: " s" (()" validate . cr
." ()) is valid: " s" ())" validate . cr
