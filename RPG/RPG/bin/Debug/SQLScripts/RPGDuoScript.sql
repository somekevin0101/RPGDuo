create table Rumor
(RumorID int identity(1,1) not null,
RumorText varchar(1000) not null,

Constraint pk_Rumor Primary Key (RumorID) 
);

Create table HeroType
(HeroID int identity(1,1) not null,
Hero varchar (100) not null,

constraint pk_HeroType primary key (HeroID)
);

Create table Hero_Rumor
(HeroID int not null,
RumorID int not null,

constraint pk_HeroRumor primary key (HeroID, RumorID),
constraint fk_HeroRumor_Hero foreign key (HeroID) References HeroType(HeroID),
constraint fk_HeroRumor_Rumor foreign key (RumorID) References Rumor(RumorID),
);

insert into Rumor (RumorText) 
	values('Just a few beers has always made a warrior a bit tougher in the battle arena. Anything more than that will lead to death'),
('Probably for the best if you do not try to cheat the barkeep'),	
('If you manage to kill the dragon it will prove you can be trusted with any quest'),
('After my reputation was tarnished and I was kicked out of my house,
 I went to the inn to sleep. That mean lady made me sleep with the horses, but I still felt refreshed in the morning'),
 ('If you inquire about a quest at the hall, and then decide not to do it you will make those crotchety old coucil members upset'),
 ('It''s good to be lucky at the games but only up to a certain point. They''ll likely think you''re cheating'),
 ('I once wanted to be a hero, but I came to the conclusion that only god can choose who will do great things in this world'),
 ('In this world you only have one chance at things, there are no do overs. I had a friend who lost his life in the arena and he''s gone forever. I''ve heard others talk of a way to go back and try again, but that''s a fools belief.'),
 ('I think the best strategy in the arena is to fight several small battles to improve your reputation. Too bad it''s not up to you who you fight'),
 ('People in this town have little respect for would be heroes who get publicly drunk'),
 ('You seem a bit out of place in here, you''re not going to start preaching at me are you?'),
 ('It''s always nice to see an example of how God works through broken instruments'),
 ('Easy buddy, you better not try to start any trouble in here'),
 ('Are you trying to scare people? Maybe you should try to smile a bit'),
 ('I love to watch big dummnies like you fall at the arena'),
 ('It must really suck having to duck your head every time you enter a room'),
 ('Dear lord a brave knight. I don''t need rescuing, please don''t try that stuff with me'),
 ('Shouldn''t you be out questing or something? This is a bar, not a place for heroics'),
 ('I happen to think archers are just smart by standing far away and slinging arrows. I seem to be in the minority in this town'),
 ('Don''t let old Thurgrand get to you, he just really does''t like people who stand from afar and shoot arrows at people like a coward')

 insert into HeroType (Hero)
 values('Priest'),('Thug'),('Barbarian'),('Knight'),('Archer')

 insert into Hero_Rumor
 values (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8), (1,9), (1,10), (1,11), (1,12),
 (2,1), (2,2), (2,3), (2,4), (2,5), (2,6), (2,7), (2,8), (2,9), (2,10), (2,13), (2,14),
 (3,1), (3,2), (3,3), (3,4), (3,5), (3,6), (3,7), (3,8), (3,9), (3,10), (3,15), (3,16),
 (4,1), (4,2), (4,3), (4,4), (4,5), (4,6), (4,7), (4,8), (4,9), (4,10), (4,17), (4,18),
 (5,1), (5,2), (5,3), (5,4), (5,5), (5,6), (5,7), (5,8), (5,9), (5,10), (5,19), (5,20)