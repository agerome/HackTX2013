#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <math.h>

int main(){
	int i=1;
	srand(time(NULL));
	while (i==1){
		int x;
		for (x=1; x<205; x++){
			double random_number = rand()%10000;
			random_number = random_number / 10000;
			if (random_number >= .5){
				random_number++;	
			}
		int a = (int) random_number;
		printf("%d", a);
		}
	printf("\n");
	}
}
	
	
