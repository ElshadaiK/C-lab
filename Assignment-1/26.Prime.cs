using System;

namespace HelloWorld{
    class Prime
    {
        public void prime(){
            int sum = 2;
            int count = 1;
            for(int i = 2; count < 500; i++){
                int div = 0;
                for(int j = 2; j <= i/2 +1; j++){
                    if(i % j == 0){
                        ++div;
                    }
                    if(div > 2){
                        break;
                    }
                }
                
                if(div == 0){
                    sum += i;
                    count++;

                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }

    }
}