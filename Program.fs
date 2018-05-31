let sayIt = printfn @"
                            %s
                            __________________
                                              \
                                               \
                                                `  `                                                
                                              `/+  /:`                                              
                                            `/ss+  /++:`                                            
                                          `/ssss+  /++++:.                                          
                                        ./ssssss+  /++++++/.                                        
                                      ./ssssssss+  /++++++++/.                                      
                                    ./ssssssssss+  /++++++++++/.                                    
                                  ./ssssssssssss+  +++++++++++++/-                                  
                                ./ssssssssssssss/  /++++++++++++++/-`                               
                              ./ssssssssssssss+.    ./+++++++++++++++-`                             
                            ./ssssssssssssss+.        ./+++++++++++++++-`                           
                          .+ssssssssssssss+.  `:+       ./+++++++++++++++:`                         
                        .+ssssssssssssss+.  `:os+         ./+++++++++++++++:`                       
                      .+ssssssssssssss+.  `:osss+           ./+++++++++++++++:`                     
                    .+ssssssssssssss+.  `:osssss+             ./+++++++++++++++/.                   
                  .+ssssssssssssss+.  `:osssssss+               ./+++++++++++++++/.                 
                 /sssssssssssssso-   .osssssssss+                 -++++++++++++++++:                
                  -+ssssssssssssso/`  `:osssssss+               `:+++++++++++++++/.                 
                    -+ssssssssssssso/`  `:osssss+             `:+++++++++++++++/.                   
                      -+ssssssssssssss/.  `:osss+           `:+++++++++++++++/.                     
                        -+ssssssssssssss/.  `:os+         .:+++++++++++++++:.                       
                          -+ssssssssssssss/.  `:+       ./+++++++++++++++:`                         
                            .+ssssssssssssss/.  `     ./+++++++++++++++:`                           
                              .+ssssssssssssss/.    ./+++++++++++++++:`                             
                                .+ssssssssssssss/  :+++++++++++++++-`                               
                                  .+ssssssssssss+  /+++++++++++++-`                                 
                                    .+ssssssssss+  /++++++++++/-`                                   
                                      .+ssssssss+  /++++++++/-                                      
                                        .+ssssss+  /++++++/.                                        
                                          .+ssss+  /++++/.                                          
                                            .+ss+  /++/.                                            
                                              .++  /:.                                              
                                                `  `      "

[<EntryPoint>]
let main argv =
    match argv with 
        | [|message|] -> message
        | _ -> "F# rocks!"
    |> sayIt

    0