using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Monster_Hunter_Rise___PR_Tracker
{
    public partial class MainForm : Form
    {
        private List<Quest> m_Quests = new List<Quest>();
        private List<int> m_SortQuestsIndex = new List<int>();
        private List<RunRecord> m_Records = new List<RunRecord>();

        public MainForm()
        {
            InitializeComponent();

            #region Quests
            // Village lvl 2
            m_Quests.Add(new Quest("Grizzly Glutton",                     new[] { LargeMonster.Arzuros                                                    }, QuestType.Village,   2));
            m_Quests.Add(new Quest("Out Cold",                            new[] { LargeMonster.Great_Baggi                                                }, QuestType.Village,   2));
            m_Quests.Add(new Quest("Rabid Rabbit",                        new[] { LargeMonster.Lagombi                                                    }, QuestType.Village,   2));
            m_Quests.Add(new Quest("Great Izuchi, Great Pain",            new[] { LargeMonster.Great_Izuchi                                               }, QuestType.Village,   2));

            // Village lvl 3
            m_Quests.Add(new Quest("Can't Stomach the Thought",           new[] { LargeMonster.Tetranadon                                                 }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Walking on Eggshells",                new[] { LargeMonster.Kulu1Ya1Ku                                                 }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Fightin' Dirty",                      new[] { LargeMonster.Barroth                                                    }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Obnoxious Lord, Noxious Monster",     new[] { LargeMonster.Great_Wroggi                                               }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Spongy Oasis",                        new[] { LargeMonster.Royal_Ludroth                                              }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Feathered Frenzy",                    new[] { LargeMonster.Aknosom                                                    }, QuestType.Village,   3));
            m_Quests.Add(new Quest("Faceless Foe",                        new[] { LargeMonster.Khezu                                                      }, QuestType.Village,   3));

            // Village lvl 4
            m_Quests.Add(new Quest("Infernal Lacrimosa",                  new[] { LargeMonster.Somnacanth                                                 }, QuestType.Village,   4));
            m_Quests.Add(new Quest("Raging White-Out",                    new[] { LargeMonster.Barroth                                                    }, QuestType.Village,   4));
            m_Quests.Add(new Quest("The Queen's Procession",              new[] { LargeMonster.Rathian                                                    }, QuestType.Village,   4));
            m_Quests.Add(new Quest("Streaking Shadow",                    new[] { LargeMonster.Tobi1Kadachi                                               }, QuestType.Village,   4));
            m_Quests.Add(new Quest("A song of Red and Fire",              new[] { LargeMonster.Volvidon                                                   }, QuestType.Village,   4));
            m_Quests.Add(new Quest("Off Your Rocker",                     new[] { LargeMonster.Basarios                                                   }, QuestType.Village,   4));
            m_Quests.Add(new Quest("Monkey Wrench in Your Plan",          new[] { LargeMonster.Bishaten                                                   }, QuestType.Village,   4));
            m_Quests.Add(new Quest("A Poisonous Project",                 new[] { LargeMonster.Pukei1Pukei                                                }, QuestType.Village,   4));
            m_Quests.Add(new Quest("Third Wheel",                         new[] { LargeMonster.Arzuros, LargeMonster.Tetranadon                           }, QuestType.Village,   4));

            // Village lvl 5
            m_Quests.Add(new Quest("Wind Speed Wyvern",                   new[] { LargeMonster.Nargacuga                                                  }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Electrifying Epiphany",               new[] { LargeMonster.Zinogre                                                    }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Nocturnal Tracker",                   new[] { LargeMonster.Anjanath                                                   }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Waltzing by Moonlight",               new[] { LargeMonster.Mizutsune                                                   }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Rathalos Alert!",                     new[] { LargeMonster.Rathalos                                                   }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Comeuppance",                         new[] { LargeMonster.Magnamalo                                                  }, QuestType.Village,   5));
            m_Quests.Add(new Quest("The Secret Ingredient",               new[] { LargeMonster.Somnacanth                                                 }, QuestType.Village,   5));
            m_Quests.Add(new Quest("BZZZZZ or ZZZZzzzz",                  new[] { LargeMonster.Khezu, LargeMonster.Somnacanth                             }, QuestType.Village,   5));
            m_Quests.Add(new Quest("Nosey Nuisances",                     new[] { LargeMonster.Kulu1Ya1Ku, LargeMonster.Anjanath                          }, QuestType.Village,   5));
            m_Quests.Add(new Quest("The Hottest Around",                  new[] { LargeMonster.Tetranadon, LargeMonster.Volvidon                          }, QuestType.Village,   5));

            // Village lvl 6
            m_Quests.Add(new Quest("Hermit of the Swamp",                 new[] { LargeMonster.Almudron                                                   }, QuestType.Village,   6));
            m_Quests.Add(new Quest("Abominable Snow-Beast",               new[] { LargeMonster.Goss_Harag                                                 }, QuestType.Village,   6));
            m_Quests.Add(new Quest("Thundering Voice",                    new[] { LargeMonster.Tigrex                                                     }, QuestType.Village,   6));
            m_Quests.Add(new Quest("Twisted Desire",                      new[] { LargeMonster.Diablos                                                    }, QuestType.Village,   6));
            m_Quests.Add(new Quest("A Test of Courage",                   new[] { LargeMonster.Magnamalo, LargeMonster.Zinogre                            }, QuestType.Village,   6));
            m_Quests.Add(new Quest("Like a Flash of Lightning",           new[] { LargeMonster.Tobi1Kadachi, LargeMonster.Mizutsune                        }, QuestType.Village,   6));
            m_Quests.Add(new Quest("King of the Sky, Bane of the Land",   new[] { LargeMonster.Rathalos, LargeMonster.Tigrex                              }, QuestType.Village,   6));
            m_Quests.Add(new Quest("Advanced: The Veteran's Gala",        new[] { LargeMonster.Bazelgeuse, LargeMonster.Magnamalo, LargeMonster.Rajang    }, QuestType.Village,   6));

            // Hub lvl 1
            m_Quests.Add(new Quest("Shady Monster",                       new[] { LargeMonster.Aknosom                                                    }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("Tired and Feathered",                 new[] { LargeMonster.Kulu1Ya1Ku                                                 }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("Jumped in the Frost Islands",         new[] { LargeMonster.Great_Izuchi                                               }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("No Cure for the Common Baggi",        new[] { LargeMonster.Great_Baggi                                                }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("A Snowball's Chance...",              new[] { LargeMonster.Lagombi                                                    }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("Wroggi Place, Wroggi Time",           new[] { LargeMonster.Great_Wroggi                                               }, QuestType.Hub,       1));
            m_Quests.Add(new Quest("A Grizzly Encounter",                 new[] { LargeMonster.Arzuros                                                    }, QuestType.Hub,       1));

            // Hub lvl 2
            m_Quests.Add(new Quest("I Want Off This Ride",                new[] { LargeMonster.Bishaten                                                   }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Way of the Pukei",                    new[] { LargeMonster.Pukei1Pukei                                                }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("The Flooding Flooded Forest",         new[] { LargeMonster.Royal_Ludroth                                              }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("So Muddy Hardheaded",                 new[] { LargeMonster.Barroth                                                    }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("A Pale Shadow",                       new[] { LargeMonster.Arzuros                                                    }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Reinventing the Wheel",               new[] { LargeMonster.Volvidon                                                   }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Blasted Basarios!",                   new[] { LargeMonster.Basarios                                                   }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("The Path of Royalty",                 new[] { LargeMonster.Rathian                                                    }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Dead Ringer",                         new[] { LargeMonster.Tetranadon                                                 }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Bouncing Brawlers",                   new[] { LargeMonster.Lagombi, LargeMonster.Tetranadon                           }, QuestType.Hub,       2));
            m_Quests.Add(new Quest("Fried and Baptized",                  new[] { LargeMonster.Royal_Ludroth, LargeMonster.Rathian                        }, QuestType.Hub,       2));

            // Hub lvl 3
            m_Quests.Add(new Quest("Beckoning Slumber",                   new[] { LargeMonster.Somnacanth                                                 }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("The Blizzard Blender",                new[] { LargeMonster.Goss_Harag                                                 }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Zigzagging Zapper",                   new[] { LargeMonster.Tobi1Kadachi                                               }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Down 'n' Dirty",                      new[] { LargeMonster.Almudron                                                   }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Bully of the Caverns",                new[] { LargeMonster.Anjanath                                                   }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Twilit Twin Stars",                   new[] { LargeMonster.Nargacuga                                                  }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("My Muse the Mizutsune",               new[] { LargeMonster.Mizutsune                                                  }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Champion of the Caverns",             new[] { LargeMonster.Rathalos                                                   }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Wavering Moon and Thunder",           new[] { LargeMonster.Zinogre                                                    }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("White Knight vs. Hunter",             new[] { LargeMonster.Barioth                                                    }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("A Friend in Need",                    new[] { LargeMonster.Tigrex                                                     }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Hellfire",                            new[] { LargeMonster.Magnamalo                                                  }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Tail to Tail",                        new[] { LargeMonster.Bishaten, LargeMonster.Almudron                            }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Beastly Chaos",                       new[] { LargeMonster.Tigrex, LargeMonster.Goss_Harag                            }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("Disastrously Beautiful",              new[] { LargeMonster.Barroth, LargeMonster.Magnamalo, LargeMonster.Tobi1Kadachi }, QuestType.Hub, 3));
            m_Quests.Add(new Quest("A Few Bumps Along the Way",           new[] { LargeMonster.Diablos                                                    }, QuestType.Hub, 3));

            // Hub lvl 4
            m_Quests.Add(new Quest("The Swirling Gale",                   new[] { LargeMonster.Great_Izuchi                                               }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Divine Comedy",                       new[] { LargeMonster.Arzuros, LargeMonster.Kulu1Ya1Ku                           }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Didn't Get The Money",                new[] { LargeMonster.Great_Baggi, LargeMonster.Great_Baggi                      }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Dancing A-Purr-Ition",                new[] { LargeMonster.Aknosom                                                    }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("The Frost Islands Arena",             new[] { LargeMonster.Tetranadon                                                 }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Even Cute Things Have Fangs",         new[] { LargeMonster.Lagombi                                                    }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Night of the Khezu",                  new[] { LargeMonster.Khezu                                                      }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Totally not Cool, Kulu!",             new[] { LargeMonster.Kulu1Ya1Ku                                                 }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Study the Sword & Shield",            new[] { LargeMonster.Aknosom                                                    }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Honing Your Hunting Horn",            new[] { LargeMonster.Great_Izuchi, LargeMonster.Tetranadon                      }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Study the Switch Axe",                new[] { LargeMonster.Lagombi, LargeMonster.Khezu                                }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Learning the Light Bowgun",           new[] { LargeMonster.Great_Baggi, LargeMonster.Great_Wroggi                     }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Donning Toxicity",                    new[] { LargeMonster.Great_Wroggi                                               }, QuestType.Hub, 4));
            m_Quests.Add(new Quest("Blue, Round and Cute",                new[] { LargeMonster.Arzuros                                                    }, QuestType.Hub, 4));

            // Hub lvl 5
            m_Quests.Add(new Quest("Foul Play in the Forest",             new[] { LargeMonster.Royal_Ludroth                                              }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Rise Above the Mud",                  new[] { LargeMonster.Barroth                                                    }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Bowled Over",                         new[] { LargeMonster.Volvidon, LargeMonster.Volvidon                            }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Rotten Fruit",                        new[] { LargeMonster.Bishaten                                                   }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Go Away, Pukei!",                     new[] { LargeMonster.Pukei1Pukei                                                }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Miner Problem",                       new[] { LargeMonster.Basarios                                                   }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Charmed by the Queen",                new[] { LargeMonster.Rathian                                                    }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("The Restless Swamp",                  new[] { LargeMonster.Jyuratodus                                                 }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Grasp the Great Sword",               new[] { LargeMonster.Bishaten, LargeMonster.Bishaten                            }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Honing Your Hammer",                  new[] { LargeMonster.Pukei1Pukei, LargeMonster.Barroth                          }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Learn the Lance",                     new[] { LargeMonster.Rathian                                                    }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Charge Blade Coalescing",             new[] { LargeMonster.Royal_Ludroth, LargeMonster.Jyuratodus                     }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Hone yuor Heavy Bowgun",              new[] { LargeMonster.Basarios, LargeMonster.Volvidon                            }, QuestType.Hub, 5));
            m_Quests.Add(new Quest("Shadows Over the Frost",              new[] { LargeMonster.Khezu, LargeMonster.Tetranadon                             }, QuestType.Hub, 5));

            // Hub lvl 6
            m_Quests.Add(new Quest("Skies Flash, Clouds Boom",            new[] { LargeMonster.Zinogre                                                    }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("A Somniferous Elegy",                 new[] { LargeMonster.Somnacanth                                                 }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Sharpening Amber Fangs",              new[] { LargeMonster.Barioth                                                    }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Skies are Gray",                      new[] { LargeMonster.Tobi1Kadachi                                               }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Closer than it Appears",              new[] { LargeMonster.Anjanath                                                   }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("The Abyss Stares Back",               new[] { LargeMonster.Nargacuga                                                  }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Red Skies at Night",                  new[] { LargeMonster.Rathalos                                                   }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("A Bewitching Dance",                  new[] { LargeMonster.Mizutsune                                                  }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Do it for the Dango!",                new[] { LargeMonster.Nargacuga, LargeMonster.Jyuratodus                         }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Learn the Long Sword",                new[] { LargeMonster.Zinogre, LargeMonster.Mizutsune                            }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Dissect the Dual Blades",             new[] { LargeMonster.Anjanath, LargeMonster.Rathian                             }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Grasp the Gunlance",                  new[] { LargeMonster.Barioth                                                    }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Invoke the Insect Glaive",            new[] { LargeMonster.Somnacanth, LargeMonster.Aknosom                           }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Be One with the Bow",                 new[] { LargeMonster.Tobi1Kadachi, LargeMonster.Tobi1Kadachi                    }, QuestType.Hub, 6));
            m_Quests.Add(new Quest("Showdown in the Arena",               new[] { LargeMonster.Anjanath, LargeMonster.Zinogre, LargeMonster.Mizutsune     }, QuestType.Hub, 6));

            // Hub lvl 7
            m_Quests.Add(new Quest("It's Gonna Get You",                  new[] { LargeMonster.Goss_Harag                                                 }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Clad in Hellfire",                    new[] { LargeMonster.Magnamalo                                                  }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Muddy Invitation",                  new[] { LargeMonster.Almudron                                                   }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Subterranean Disturbances",           new[] { LargeMonster.Diablos                                                    }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Resounding Roar",                   new[] { LargeMonster.Tigrex                                                     }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Evil Afoot",                          new[] { LargeMonster.Rajang                                                     }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Can't Kill it With Fire",             new[] { LargeMonster.Rakna1Kadaki                                               }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Serpent Goddess of Thunder",          new[] { LargeMonster.Thunder_Serpent_Narwa                                      }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Seared Situation",                    new[] { LargeMonster.Rathalos, LargeMonster.Magnamalo                           }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Quartet of Horns",                  new[] { LargeMonster.Diablos, LargeMonster.Diablos                              }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Ruckus in the Ruins",                 new[] { LargeMonster.Almudron, LargeMonster.Mizutsune                           }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Frosty Stalemate",                  new[] { LargeMonster.Goss_Harag, LargeMonster.Tetranadon                        }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Fought, Failed, Fired Up",            new[] { LargeMonster.Diablos, LargeMonster.Anjanath                             }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Occupational Hazards",                new[] { LargeMonster.Zinogre, LargeMonster.Rajang                               }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Omnidirectional Threats",             new[] { LargeMonster.Rakna1Kadaki, LargeMonster.Khezu                           }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Whirlwind of a Stage",              new[] { LargeMonster.Nargacuga, LargeMonster.Tigrex, LargeMonster.Tobi1Kadachi  }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("A Blaze Among Beasts",                new[] { LargeMonster.Rakna1Kadaki, LargeMonster.Rathian, LargeMonster.Tigrex    }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("May Fire Quell Fury",                 new[] { LargeMonster.Rajang                                                     }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Death from Above",                    new[] { LargeMonster.Bazelgeuse                                                 }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Master Utsushi's Challenge Part 1",   new[] { LargeMonster.Zinogre, LargeMonster.Almudron                             }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Master Utsushi's Challenge Part 2",   new[] { LargeMonster.Goss_Harag, LargeMonster.Rajang                            }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Master Utsushi's Challenge Part 3",   new[] { LargeMonster.Nargacuga, LargeMonster.Magnamalo                          }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("The Allmother",                       new[] { LargeMonster.Wind_Serpent_Ibushi, LargeMonster.Narwa_the_Allmother      }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Master Utsushi's Challenge Part 4",   new[] { LargeMonster.Tigrex, LargeMonster.Anjanath                              }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Master Utsushi's Challenge Part 5",   new[] { LargeMonster.Rakna1Kadaki, LargeMonster.Rathalos                        }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("The Crimson Glow",                    new[] { LargeMonster.Crimson_Glow_Valstrax                                      }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("The Fearsome Apex Rathalos",          new[] { LargeMonster.Apex_Rathalos                                              }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("The Devastating Apex Diablos",        new[] { LargeMonster.Apex_Diablos                                               }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("The Voltaic Apex Zinogre",            new[] { LargeMonster.Apex_Zinogre                                               }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Dual Calamities",           new[] { LargeMonster.Magnamalo, LargeMonster.Bazelgeuse                         }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Monsters in Ink",           new[] { LargeMonster.Goss_Harag, LargeMonster.Tigrex, LargeMonster.Mizutsune    }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Of Storm and Fire",         new[] { LargeMonster.Kushala_Daora, LargeMonster.Teostra                        }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Scaredy-Cat",               new[] { LargeMonster.Chameleos, LargeMonster.Rajang                             }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: The Fallen Comet",          new[] { LargeMonster.Crimson_Glow_Valstrax, LargeMonster.Rakna1Kadaki           }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Proof of Power",            new[] { LargeMonster.Diablos, LargeMonster.Magnamalo, LargeMonster.Rathalos     }, QuestType.Hub, 7));
            m_Quests.Add(new Quest("Advanced: Those Crowned Apex",        new[] { LargeMonster.Apex_Mizutsune, LargeMonster.Apex_Rathalos, LargeMonster.Apex_Zinogre   }, QuestType.Hub, 7));
            #endregion

            ResetTable();

            LoadRecords();

            UpdateGrid();
        }

        private void FilterClick(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                List<string> filters = form.Filters;

                if (filters.Count > 0)
                {
                    QuestResultTable.Rows.Clear();
                    QuestResultTable.Columns.Clear();
                    QuestResultTable.Refresh();
                    m_SortQuestsIndex.Clear();

                    QuestResultTable.Columns.Add("QuestName", "Quest Name");

                    string[] weaponArray = Enum.GetNames(typeof(Weapon));
                    string[] monsterNames = Enum.GetNames(typeof(LargeMonster));
                    string[] questTypes = Enum.GetNames(typeof(QuestType));

                    List<int> lvls = new List<int>();
                    List<LargeMonster> monsters = new List<LargeMonster>();
                    List<QuestType> type = new List<QuestType>();
                    bool completedOnly = false;

                    for (int i = 0; i < filters.Count; i++)
                    {
                        if (filters[i].Contains("Rank"))
                        {
                            int lvl = 0;
                            int.TryParse(filters[i].Replace("Rank", string.Empty), out lvl);

                            lvls.Add(lvl);
                        }

                        for (int j = 0; j < monsterNames.Length; j++)
                        {
                            if (filters[i] == monsterNames[j])
                            {
                                monsters.Add((LargeMonster)j);
                                break;
                            }
                        }

                        for (int j = 0; j < weaponArray.Length; j++)
                        {
                            if (weaponArray[j] == filters[i])
                            {
                                QuestResultTable.Columns.Add(weaponArray[j], weaponArray[j].Replace("_", " "));
                                break;
                            }
                        }

                        for (int j = 0; j < questTypes.Length; j++)
                        {
                            if (filters[i] == questTypes[j])
                            {
                                type.Add((QuestType)j);
                            }
                        }

                        if (filters[i] == "Completed")
                        {
                            completedOnly = true;
                        }
                    }

                    if (QuestResultTable.Columns.Count <= 1)
                    {
                        for (int i = 0; i < weaponArray.Length; i++)
                        {
                            QuestResultTable.Columns.Add(weaponArray[i], weaponArray[i].Replace("_", " "));
                        }
                    }

                    for (int i = 0; i < m_Quests.Count; i++)
                    {
                        if (lvls.Count > 0)
                        {
                            bool containsLvl = false;

                            foreach (int lvl in lvls)
                            {
                                if (lvl == m_Quests[i].Level)
                                {
                                    containsLvl = true;
                                    break;
                                }
                            }

                            if (!containsLvl)
                                continue;
                        }

                        if (completedOnly)
                        {
                            bool questComplete = false;

                            foreach (RunRecord record in m_Records)
                            {
                                if (m_Quests[i].QuestName == record.QuestName)
                                {
                                    questComplete = true;
                                    break;
                                }
                            }

                            if (!questComplete)
                                continue;
                        }

                        if (type.Count > 0)
                        {
                            bool containsType = false;

                            foreach (QuestType questType in type)
                            {
                                if (m_Quests[i].Type == questType)
                                {
                                    containsType = true;
                                }
                            }

                            if (!containsType)
                                continue;
                        }

                        if (monsters.Count > 0)
                        {
                            foreach (LargeMonster monster in m_Quests[i].Monster)
                            {
                                foreach (LargeMonster filterMonster in monsters)
                                {
                                    if (monster == filterMonster)
                                    {
                                        m_SortQuestsIndex.Add(i);

                                        QuestResultTable.Rows.Add(m_Quests[i].QuestName);
                                    }
                                }
                            }
                        }
                        else
                        {
                            m_SortQuestsIndex.Add(i);

                            QuestResultTable.Rows.Add(m_Quests[i].QuestName);
                        }
                    }
                }
                else
                {
                    ResetTable();
                }

                UpdateGrid();
            }
        }

        private void InfoClick(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.Show();
        }

        private void SaveForm(object sender, EventArgs e)
        {
            string file = string.Empty;

            foreach (RunRecord record in m_Records)
            {
                file += record.QuestName + "," + record.weapon + "," + record.Rule + "," + record.Minutes + "," + record.Seconds + "," + record.Milliseconds + "\n";
            }

            System.IO.File.WriteAllText("records.txt", file);
        }

        private void LoadRecords()
        {
            if (System.IO.File.Exists("records.txt"))
            {
                string[] records = System.IO.File.ReadAllLines("records.txt");

                foreach (string record in records)
                {
                    m_Records.Add(new RunRecord(record));
                }
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;

            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            tabControl1.SelectedIndex = index - 1;
        }

        private void ResetTable()
        {
            QuestResultTable.Rows.Clear();
            QuestResultTable.Columns.Clear();
            QuestResultTable.Refresh();
            m_SortQuestsIndex.Clear();

            QuestResultTable.Columns.Add("QuestName", "Quest Name");

            string[] weaponArray = Enum.GetNames(typeof(Weapon));

            for (int i = 0; i < weaponArray.Length; i++)
            {
                QuestResultTable.Columns.Add(weaponArray[i], weaponArray[i].Replace("_", " "));
            }

            for (int i = 0; i < m_Quests.Count; i++)
            {
                QuestResultTable.Rows.Add(m_Quests[i].QuestName);
            }
        }

        private void OpenNewRunForm(object sender, EventArgs e)
        {
            NewRunForm form = new NewRunForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                RunRecord record = new RunRecord(tabControl1.SelectedTab.Text, form.weapon, form.rules, form.Minutes, form.Seconds, form.Milliseconds);

                m_Records.Add(record);

                DataGridView grid = null;

                foreach (Control control in tabControl1.SelectedTab.Controls)
                {
                    if (control is DataGridView)
                    {
                        grid = (DataGridView)control;
                        break;
                    }
                }

                if (grid == null)
                    return;

                grid.Rows.Add(record.Time, record.weapon, record.Rule);

                UpdateGrid();
            }
        }

        private System.EventHandler NewTab(Quest aQuest)
        {
            TabPage tabPage2 = new TabPage();
            DataGridView dataGridView1 = new DataGridView();
            Panel panel1 = new Panel();
            Button newButton = new Button();
            Button closeButton = new Button();
            Label QuestNameLabel = new Label();
            Label CreatureNameLabel = new Label();
            Label StarLabel = new Label();

            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 398);
            tabPage2.Text = aQuest.QuestName;
            
            panel1.Controls.Add(StarLabel);
            panel1.Controls.Add(CreatureNameLabel);
            panel1.Controls.Add(QuestNameLabel);
            panel1.Controls.Add(newButton);
            panel1.Controls.Add(closeButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 53);
            panel1.TabIndex = 0;

            StarLabel.AutoSize = true;
            StarLabel.Location = new Point(6, 32);
            StarLabel.Name = "StarLabel";
            StarLabel.Size = new Size(38, 15);
            StarLabel.TabIndex = 3;
            StarLabel.Text = aQuest.Type.ToString() + ": " + aQuest.Level.ToString() + "⚝";

            string monsters = string.Empty;

            for (int i = 0; i < aQuest.Monster.Length; i++)
            {
                monsters += aQuest.Monster[i].ToString().Replace("_", " ").Replace("1", "-") + ", ";
            }

            monsters = monsters.Remove(monsters.Length - 2, 2);

            CreatureNameLabel.AutoSize = true;
            CreatureNameLabel.Location = new Point(6, 15);
            CreatureNameLabel.Name = "CreatureNameLabel";
            CreatureNameLabel.Size = new Size(38, 15);
            CreatureNameLabel.TabIndex = 2;
            CreatureNameLabel.Text = monsters;
 
            QuestNameLabel.AutoSize = true;
            QuestNameLabel.Location = new Point(6, -3);
            QuestNameLabel.Name = "QuestNameLabel";
            QuestNameLabel.Size = new Size(38, 15);
            QuestNameLabel.TabIndex = 1;
            QuestNameLabel.Text = aQuest.QuestName;

            newButton.Location = new Point(706, 15);
            newButton.Name = "newButton";
            newButton.Size = new Size(75, 23);
            newButton.TabIndex = 0;
            newButton.Text = "New Run";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new EventHandler(OpenNewRunForm);

            closeButton.Location = new Point(626, 15);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += new EventHandler(CloseForm);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(786, 339);
            dataGridView1.TabIndex = 1;

            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Weapon", "Weapon");
            dataGridView1.Columns.Add("Style", "TA / Freestyle");

            for (int i = 0; i < m_Records.Count; i++)
            {
                if (m_Records[i].QuestName == aQuest.QuestName)
                {
                    dataGridView1.Rows.Add(m_Records[i].Time, m_Records[i].weapon, m_Records[i].Rule);
                }
            }

            tabControl1.TabPages.Add(tabPage2);

            return null;
        }

        private void QuestResultTable_MouseClick(object sender, MouseEventArgs e)
        {
            int hitIndex = QuestResultTable.HitTest(e.X, e.Y).RowIndex;

            if (m_SortQuestsIndex.Count > 0)
            {
                if (hitIndex > m_SortQuestsIndex.Count || hitIndex < 0)
                    return;
            }

            int questIndex = m_SortQuestsIndex.Count == 0 ? hitIndex : m_SortQuestsIndex[hitIndex];

            if (e.Button == MouseButtons.Right && !TabExists(m_Quests[questIndex]))
            {
                ContextMenuStrip context = new ContextMenuStrip();

                ToolStripMenuItem item = new ToolStripMenuItem("Edit Runs");

                item.Click += NewTab(m_Quests[questIndex]);
                context.Items.Add(item);
            }
        }

        private bool TabExists(Quest aQuest)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (tab.Text == aQuest.QuestName)
                    return true;
            }

            return false;
        }

        private void UpdateGrid()
        {
            for (int i = 0; i < QuestResultTable.Rows.Count; i++)
            {
                foreach (string weapon in Enum.GetNames(typeof(Weapon)))
                {
                    for (int j = 0; j < QuestResultTable.Columns.Count; j++)
                    {
                        if (QuestResultTable.Columns[j].Name == weapon)
                        {
                            int currentLowestTime = -1;

                            foreach (RunRecord record in m_Records)
                            {
                                if (record.QuestName == (string)QuestResultTable.Rows[i].Cells["QuestName"].Value && record.weapon.ToString() == weapon)
                                {
                                    if (currentLowestTime == -1 || currentLowestTime > record.CompareTime)
                                    {
                                        QuestResultTable.Rows[i].Cells[weapon].Value = record.Time;
                                        currentLowestTime = record.CompareTime;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            QuestResultTable.Refresh();
        }
    }
}