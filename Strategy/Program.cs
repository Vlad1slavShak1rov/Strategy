using Strategy;

Player player = new Player("Толик", new Axe());
Games games = new Games(player);

player.Attack();
games.SelectWeapon(new Bow());

player.Attack();
games.SelectWeapon(new Sword());

player.Attack();