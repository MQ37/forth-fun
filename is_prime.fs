: divisible ( n n -- b )
    mod 0= ;

: get_stop_index ( n -- n )
    { n }
     n 0 d>f \ convert to float
     fsqrt \ sqrt
     f>s 1+ dup 2 < if \ if sqrt <= 2 loop to 3
        drop 3
     endif ;

: is_prime ( n -- b )
     { n }
     true \ base case 
     n get_stop_index 2 do
         I n = if \ case for sqrt <= 2
            unloop exit
         endif
         n I divisible if
            drop false unloop exit
         endif
     loop ;

." is 11 prime? " 11 is_prime . cr
." is 3 prime? " 3 is_prime . cr
." is 2 prime? " 2 is_prime . cr
." is 17 prime? " 17 is_prime . cr
." is 21 prime? " 21 is_prime . cr
." is 9823 prime? " 9823 is_prime . cr
