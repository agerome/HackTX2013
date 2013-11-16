#include <stdio.h>
#include <math.h>
#include <time.h>
#include <string.h>
#include <stdlib.h>

struct character {
		char *name;
		int health;
		int defense;
		int attack;
};

struct character* create(char *name, int health, int defense, int attack)
{
		struct character* charID = malloc(sizeof(struct character));
		
		charID->name = strdup(name);
		charID->health = health;
		charID->defense = defense;
		charID->attack = attack;

		return charID;
}

void character_delete(struct character* charID)
{
		free(charID->name);
		free(charID);
}

void list_stats(struct character* charID)
{
		printf("\tName: %s\n", charID->name);
		printf("\tHealth: %d\n", charID->health);
		printf("\tDefense: %d\n", charID->defense);
		printf("\tAttack: %d\n", charID->attack);
}

void battle(struct character* hero, struct character* enemy){
		int x = 0;
		printf("\n\n\t-----%s has entered a battle with %s!-----\n\n", hero->name, enemy->name);
		printf("What do you choose to do?\n");
		printf("%s's health: %d\t\t %s's health: %d\n", hero->name, hero->health, enemy->name, enemy->health);
		printf("[a]- attack\t [d]- defend\n[r]- run away\t Choose one!\n");
		scanf("%d", &x);
		if (x == 1){
				int d = hero->attack - enemy->defense;
				printf("%s attacked %s and did %d damage!", hero->name, enemy->name, d );
				enemy->health = enemy->health - d;
		}
		else{
				printf("derp");
		};
};

int main()
{
		char a[] = "this is filler initialization text";
		char b[] = "this too is filler initialization text";
		printf("\t-----Welcome to Dragonslayer!-----\n");
		printf("You will play the role of a brave hero, fighting against the \ntyrannical rule of an evil dragon!\n");
		printf("Many perils will await you on your journey, but fear not!\n");
		printf("You will find everything you need to defeat the dragon in due time...\n");
		printf("First things first though: What is our brave hero's name? ");
		scanf("%s", a);
		printf("And what is the name of the dragon? ");
		scanf("%s", b);
		printf("Venture forth, %s, and defeat the evil %s!\n", a, b);
		printf("\n\n");
		
		struct character* player = create(a, 50, 0, 5);
		printf("Your character's stats:\n");
		list_stats(player);
		printf("\n\n");
		
		printf("\t-------LEVEL ONE-------\n");
		printf("As you walk down the road towards the dragon cave, a small and emotionally unstable monster appears!\n");
		printf("Unfortunately, in its riled up state there seems to be no use reasoning with it.\n");
		printf("With a blood-curdling screech, the monster leaps towards our hero!\n");

		struct character* gremlin = create("Gremlin", 10, 0, 5);

		battle(player, gremlin);

		character_delete(player);
		character_delete(gremlin);
		return 0;
};

