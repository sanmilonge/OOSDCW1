/*
Module: Object Oriented Software Development 
Coursework: Coursework 1 
File: Main.cs 
Author: Oluwasanmi Longe  
Matriculation number: 40798397 
Description: Implementation and testing the BusStop class while relying on user input
 */


using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace CW1
{
    /// <summary>
    /// Main entry point, tests the BusStop class and the initially defined validation
    /// Handles and implements input validation and flow for BusStop program
    /// </summary>

    public class MainClassInput
    {
        static void Main()
        {
            BusStop stop = new(); // BusStop object
            Console.WriteLine("Welcome to the BusStop class test!\nEnter the details as shown below (enter \"quit\" in the ID field to exit this program.)");
            while (stop.Passengers < 999999) // Makes sure program terminates once number of Passengers exceeds limit
            {
                while (true)
                {
                    Console.Write("ID: ");
                    string userID = Console.ReadLine();
                    if (userID == "quit") // Exits the program when quit is entered into the ID field. This is to prevent an infinite loop
                    {
                        Console.WriteLine($"Thank you for using this program.\n{stop.Passengers} passenger(s) boarded this bus."); // Prints number of passengers
                        return; // Exits program
                    }
                    try
                    {
                        stop.ID = Convert.ToInt32(userID); // To see if an integer was entered or not
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Name: ");
                    string userName = Console.ReadLine();
                    try
                    {
                        stop.Name = userName;
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Latitude: ");
                    string userLat = Console.ReadLine();
                    try
                    {
                        stop.Latitude = Convert.ToDouble(userLat); // To check if user entered a double 
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    } // catch
                } // while loop
                while (true)
                {
                    Console.Write("Longitude: ");
                    string userLong = Console.ReadLine();
                    try
                    {
                        stop.Longitude = Convert.ToDouble(userLong);
                        break;
                    } // try
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}"); // Presents the exception as an error msg so users know what they are doing wrong
                    } // catch
                } // while loop
                stop.Board();
                Console.WriteLine("--------------------Next--------------------");
            } // while loop
        } // Main method
    } // MainClass
} // CW1



4s
27s
1m 16s
Run docker compose up --abort-on-container-exit
time="2025-10-14T13:57:46Z" level=warning msg="/home/runner/work/SoftEng/SoftEng/docker-compose.yml: the attribute `version` is obsolete, it will be ignored, please remove it to avoid potential confusion"
 db Pulling 
 806f49275cbf Pulling fs layer 
 12e135f0f080 Pulling fs layer 
 bb0089c87520 Pulling fs layer 
 59bdefbbef78 Pulling fs layer 
 6145eb690748 Pulling fs layer 
 46c5bb883eca Pulling fs layer 
 1b25d67bc0be Pulling fs layer 
 729dd3a03ada Pulling fs layer 
 1a66f49d571a Pulling fs layer 
 7faf9da2445b Pulling fs layer 
 98c1a0a82ce7 Pulling fs layer 
 59bdefbbef78 Waiting 
 6145eb690748 Waiting 
 46c5bb883eca Waiting 
 1b25d67bc0be Waiting 
 729dd3a03ada Waiting 
 1a66f49d571a Waiting 
 7faf9da2445b Waiting 
 98c1a0a82ce7 Waiting 
 12e135f0f080 Downloading [==================================================>]     884B/884B
 12e135f0f080 Download complete 
 bb0089c87520 Downloading [>                                                  ]  9.148kB/783.6kB
 bb0089c87520 Downloading [==================================================>]  783.6kB/783.6kB
 bb0089c87520 Download complete 
 806f49275cbf Downloading [>                                                  ]  503.2kB/49.5MB
 59bdefbbef78 Downloading [>                                                  ]  71.61kB/6.82MB
 6145eb690748 Downloading [=================>                                 ]     934B/2.603kB
 6145eb690748 Downloading [==================================================>]  2.603kB/2.603kB
 6145eb690748 Verifying Checksum 
 6145eb690748 Download complete 
 806f49275cbf Downloading [======>                                            ]  6.023MB/49.5MB
 59bdefbbef78 Verifying Checksum 
 59bdefbbef78 Download complete 
 46c5bb883eca Downloading [==================================================>]     334B/334B
 46c5bb883eca Verifying Checksum 
 46c5bb883eca Download complete 
 1b25d67bc0be Downloading [>                                                  ]  503.2kB/49.84MB
 806f49275cbf Downloading [============>                                      ]  12.53MB/49.5MB
 729dd3a03ada Downloading [==================================================>]     316B/316B
 729dd3a03ada Verifying Checksum 
 729dd3a03ada Download complete 
 1b25d67bc0be Downloading [=======>                                           ]  7.592MB/49.84MB
 806f49275cbf Downloading [=====================>                             ]  21.56MB/49.5MB
 1a66f49d571a Downloading [>                                                  ]  533.5kB/128.9MB
 806f49275cbf Downloading [======================================>            ]  38.14MB/49.5MB
 1a66f49d571a Downloading [====>                                              ]  11.19MB/128.9MB
 1b25d67bc0be Downloading [=============>                                     ]  13.66MB/49.84MB
 806f49275cbf Downloading [================================================>  ]  48.16MB/49.5MB
 1a66f49d571a Downloading [=======>                                           ]  18.16MB/128.9MB
 1b25d67bc0be Downloading [===========================>                       ]  27.36MB/49.84MB
 806f49275cbf Verifying Checksum 
 806f49275cbf Download complete 
 1a66f49d571a Downloading [=========>                                         ]  24.02MB/128.9MB
 1b25d67bc0be Downloading [==========================================>        ]  42.01MB/49.84MB
 806f49275cbf Extracting [>                                                  ]  524.3kB/49.5MB
 7faf9da2445b Downloading [========>                                          ]     935B/5.331kB
 7faf9da2445b Downloading [==================================================>]  5.331kB/5.331kB
 7faf9da2445b Verifying Checksum 
 7faf9da2445b Download complete 
 1b25d67bc0be Verifying Checksum 
 1b25d67bc0be Download complete 
 1a66f49d571a Downloading [===========>                                       ]  29.35MB/128.9MB
 806f49275cbf Extracting [==>                                                ]  2.097MB/49.5MB
 98c1a0a82ce7 Downloading [==================================================>]     122B/122B
 98c1a0a82ce7 Verifying Checksum 
 98c1a0a82ce7 Download complete 
 1a66f49d571a Downloading [=============>                                     ]  34.17MB/128.9MB
 806f49275cbf Extracting [=======>                                           ]   7.34MB/49.5MB
 1a66f49d571a Downloading [===============>                                   ]  38.98MB/128.9MB
 806f49275cbf Extracting [===============>                                   ]  15.73MB/49.5MB
 1a66f49d571a Downloading [=================>                                 ]   44.3MB/128.9MB
 806f49275cbf Extracting [========================>                          ]  24.12MB/49.5MB
 1a66f49d571a Downloading [===================>                               ]  50.15MB/128.9MB
 1a66f49d571a Downloading [=====================>                             ]  56.57MB/128.9MB
 806f49275cbf Extracting [===============================>                   ]  31.46MB/49.5MB
 1a66f49d571a Downloading [=======================>                           ]  61.36MB/128.9MB
 806f49275cbf Extracting [===========================================>       ]  43.52MB/49.5MB
 1a66f49d571a Downloading [===========================>                       ]   69.9MB/128.9MB
 1a66f49d571a Downloading [===============================>                   ]  80.08MB/128.9MB
 806f49275cbf Extracting [==============================================>    ]  46.14MB/49.5MB
 1a66f49d571a Downloading [================================>                  ]  83.28MB/128.9MB
 1a66f49d571a Downloading [======================================>            ]  98.17MB/128.9MB
 806f49275cbf Extracting [===============================================>   ]  46.66MB/49.5MB
 1a66f49d571a Downloading [=========================================>         ]  106.2MB/128.9MB
 806f49275cbf Extracting [==================================================>]   49.5MB/49.5MB
 806f49275cbf Pull complete 
 12e135f0f080 Extracting [==================================================>]     884B/884B
 12e135f0f080 Extracting [==================================================>]     884B/884B
 1a66f49d571a Downloading [============================================>      ]  114.2MB/128.9MB
 1a66f49d571a Downloading [===============================================>   ]  121.6MB/128.9MB
 1a66f49d571a Verifying Checksum 
 1a66f49d571a Download complete 
 12e135f0f080 Pull complete 
 bb0089c87520 Extracting [==>                                                ]  32.77kB/783.6kB
 bb0089c87520 Extracting [==================================================>]  783.6kB/783.6kB
 bb0089c87520 Extracting [==================================================>]  783.6kB/783.6kB
 bb0089c87520 Pull complete 
 59bdefbbef78 Extracting [>                                                  ]   98.3kB/6.82MB
 59bdefbbef78 Extracting [====================>                              ]  2.851MB/6.82MB
 59bdefbbef78 Extracting [==================================================>]   6.82MB/6.82MB
 59bdefbbef78 Pull complete 
 6145eb690748 Extracting [==================================================>]  2.603kB/2.603kB
 6145eb690748 Extracting [==================================================>]  2.603kB/2.603kB
 6145eb690748 Pull complete 
 46c5bb883eca Extracting [==================================================>]     334B/334B
 46c5bb883eca Extracting [==================================================>]     334B/334B
 46c5bb883eca Pull complete 
 1b25d67bc0be Extracting [>                                                  ]  524.3kB/49.84MB
 1b25d67bc0be Extracting [========>                                          ]  8.913MB/49.84MB
 1b25d67bc0be Extracting [==============>                                    ]  14.68MB/49.84MB
 1b25d67bc0be Extracting [=======================>                           ]  23.07MB/49.84MB
 1b25d67bc0be Extracting [================================>                  ]  32.51MB/49.84MB
 1b25d67bc0be Extracting [=======================================>           ]  39.85MB/49.84MB
 1b25d67bc0be Extracting [==============================================>    ]  46.66MB/49.84MB
 1b25d67bc0be Extracting [==================================================>]  49.84MB/49.84MB
 1b25d67bc0be Pull complete 
 729dd3a03ada Extracting [==================================================>]     316B/316B
 729dd3a03ada Extracting [==================================================>]     316B/316B
 729dd3a03ada Pull complete 
 1a66f49d571a Extracting [>                                                  ]  557.1kB/128.9MB
 1a66f49d571a Extracting [===>                                               ]   9.47MB/128.9MB
 1a66f49d571a Extracting [=====>                                             ]  14.48MB/128.9MB
 1a66f49d571a Extracting [=======>                                           ]   19.5MB/128.9MB
 1a66f49d571a Extracting [=========>                                         ]  24.51MB/128.9MB
 1a66f49d571a Extracting [===========>                                       ]  28.41MB/128.9MB
 1a66f49d571a Extracting [============>                                      ]   31.2MB/128.9MB
 1a66f49d571a Extracting [============>                                      ]  31.75MB/128.9MB
 1a66f49d571a Extracting [============>                                      ]  32.31MB/128.9MB
 1a66f49d571a Extracting [============>                                      ]  32.87MB/128.9MB
 1a66f49d571a Extracting [============>                                      ]  33.42MB/128.9MB
 1a66f49d571a Extracting [=============>                                     ]  33.98MB/128.9MB
 1a66f49d571a Extracting [=============>                                     ]  34.54MB/128.9MB
 1a66f49d571a Extracting [=============>                                     ]  35.09MB/128.9MB
 1a66f49d571a Extracting [=============>                                     ]  35.65MB/128.9MB
 1a66f49d571a Extracting [==============>                                    ]  36.21MB/128.9MB
 1a66f49d571a Extracting [==============>                                    ]  36.77MB/128.9MB
 1a66f49d571a Extracting [==============>                                    ]  37.32MB/128.9MB
 1a66f49d571a Extracting [==============>                                    ]  37.88MB/128.9MB
 1a66f49d571a Extracting [==============>                                    ]  38.44MB/128.9MB
 1a66f49d571a Extracting [===============>                                   ]  38.99MB/128.9MB
 1a66f49d571a Extracting [===============>                                   ]  39.55MB/128.9MB
 1a66f49d571a Extracting [===============>                                   ]  40.11MB/128.9MB
 1a66f49d571a Extracting [===============>                                   ]  40.67MB/128.9MB
 1a66f49d571a Extracting [===============>                                   ]  41.22MB/128.9MB
 1a66f49d571a Extracting [================>                                  ]  41.78MB/128.9MB
 1a66f49d571a Extracting [================>                                  ]  42.34MB/128.9MB
 1a66f49d571a Extracting [================>                                  ]  42.89MB/128.9MB
 1a66f49d571a Extracting [================>                                  ]  43.45MB/128.9MB
 1a66f49d571a Extracting [=================>                                 ]  44.01MB/128.9MB
 1a66f49d571a Extracting [=================>                                 ]  44.56MB/128.9MB
 1a66f49d571a Extracting [==================>                                ]  46.79MB/128.9MB
 1a66f49d571a Extracting [==================>                                ]  47.91MB/128.9MB
 1a66f49d571a Extracting [===================>                               ]  49.58MB/128.9MB
 1a66f49d571a Extracting [===================>                               ]  51.25MB/128.9MB
 1a66f49d571a Extracting [======================>                            ]  59.05MB/128.9MB
 1a66f49d571a Extracting [==========================>                        ]   67.4MB/128.9MB
 1a66f49d571a Extracting [=============================>                     ]  75.76MB/128.9MB
 1a66f49d571a Extracting [================================>                  ]  84.67MB/128.9MB
 1a66f49d571a Extracting [====================================>              ]  93.59MB/128.9MB
 1a66f49d571a Extracting [========================================>          ]  104.2MB/128.9MB
 1a66f49d571a Extracting [============================================>      ]  114.8MB/128.9MB
 1a66f49d571a Extracting [================================================>  ]  124.2MB/128.9MB
 1a66f49d571a Extracting [==================================================>]  128.9MB/128.9MB
 1a66f49d571a Pull complete 
 7faf9da2445b Extracting [==================================================>]  5.331kB/5.331kB
 7faf9da2445b Extracting [==================================================>]  5.331kB/5.331kB
 7faf9da2445b Pull complete 
 98c1a0a82ce7 Extracting [==================================================>]     122B/122B
 98c1a0a82ce7 Extracting [==================================================>]     122B/122B
 98c1a0a82ce7 Pull complete 
 db Pulled 
#1 [internal] load local bake definitions
#1 reading from stdin 360B done
#1 DONE 0.0s
#2 [internal] load build definition from Dockerfile
#2 transferring dockerfile: 378B done
#2 DONE 0.0s
#3 [auth] library/openjdk:pull token for registry-1.docker.io
#3 DONE 0.0s
#4 [internal] load metadata for docker.io/library/openjdk:17-jdk-slim
#4 DONE 0.3s
#5 [internal] load .dockerignore
#5 transferring context: 2B done
#5 DONE 0.0s
#6 [internal] load build context
#6 transferring context: 4.38MB 0.0s done
#6 DONE 0.0s
#7 [1/3] FROM docker.io/library/openjdk:17-jdk-slim@sha256:aaa3b3cb27e3e520b8f116863d0580c438ed55ecfa0bc126b41f68c3f62f9774
#7 resolve docker.io/library/openjdk:17-jdk-slim@sha256:aaa3b3cb27e3e520b8f116863d0580c438ed55ecfa0bc126b41f68c3f62f9774 done
#7 sha256:aaa3b3cb27e3e520b8f116863d0580c438ed55ecfa0bc126b41f68c3f62f9774 547B / 547B done
#7 sha256:779635c0c3d23cc8dbab2d8c1ee4cf2a9202e198dfc8f4c0b279824d9b8e0f22 953B / 953B done
#7 sha256:37cb44321d0423bc57266a3bff658daf00478e4cdf2d3b8091f785310534256d 4.80kB / 4.80kB done
#7 sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 1.05MB / 31.38MB 0.1s
#7 sha256:44d3aa8d076675d49d85180b0ced9daef210fe4fdff4bdbb422b9cf384e591d0 0B / 1.58MB 0.1s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 0B / 187.90MB 0.1s
#7 sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 10.49MB / 31.38MB 0.3s
#7 sha256:44d3aa8d076675d49d85180b0ced9daef210fe4fdff4bdbb422b9cf384e591d0 1.58MB / 1.58MB 0.2s done
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 12.58MB / 187.90MB 0.3s
#7 sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 26.21MB / 31.38MB 0.5s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 25.17MB / 187.90MB 0.5s
#7 sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 29.36MB / 31.38MB 0.6s
#7 sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 31.38MB / 31.38MB 0.7s done
#7 extracting sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 0.1s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 36.70MB / 187.90MB 0.9s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 50.33MB / 187.90MB 1.2s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 59.77MB / 187.90MB 1.4s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 77.45MB / 187.90MB 1.7s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 93.32MB / 187.90MB 1.9s
#7 extracting sha256:1fe172e4850f03bb45d41a20174112bc119fbfec42a650edbbd8491aee32e3c3 1.2s done
#7 extracting sha256:44d3aa8d076675d49d85180b0ced9daef210fe4fdff4bdbb422b9cf384e591d0 0.1s done
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 110.10MB / 187.90MB 2.2s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 121.63MB / 187.90MB 2.4s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 137.36MB / 187.90MB 2.7s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 153.09MB / 187.90MB 2.9s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 175.11MB / 187.90MB 3.1s
#7 sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 187.90MB / 187.90MB 3.3s done
#7 extracting sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 0.1s
#7 extracting sha256:6ce99fdf16e86bd02f6ad66a0e1334878528b5a4b5487850a76e0c08a7a27d56 1.3s done
#7 DONE 5.2s
#8 [2/3] WORKDIR /app
#8 DONE 0.0s
#9 [3/3] COPY target/*-jar-with-dependencies.jar app.jar
#9 DONE 0.0s
#10 exporting to image
#10 exporting layers
#10 exporting layers 0.4s done
#10 writing image sha256:96678379718f283c8a8b26738914911f3851bfd403e169a09d2f2948baeb18bb done
#10 naming to docker.io/library/softeng-app done
 app  Built
#10 DONE 0.4s
#11 resolving provenance for metadata file
#11 DONE 0.0s
 Network softeng_default  Creating
 Network softeng_default  Created
 Container imran-db-1  Creating
 Container imran-db-1  Created
 Container imran-app-1  Creating
 Container imran-app-1  Created
Attaching to imran-app-1, imran-db-1
imran-db-1   | 2025-10-14 13:58:08+00:00 [Note] [Entrypoint]: Entrypoint script for MySQL Server 8.0.43-1.el9 started.
imran-db-1   | 2025-10-14 13:58:08+00:00 [Note] [Entrypoint]: Switching to dedicated user 'mysql'
imran-db-1   | 2025-10-14 13:58:08+00:00 [Note] [Entrypoint]: Entrypoint script for MySQL Server 8.0.43-1.el9 started.
imran-app-1  | Connecting to database...
imran-db-1   | 2025-10-14 13:58:08+00:00 [Note] [Entrypoint]: Initializing database files
Warning: 1   | 2025-10-14T13:58:08.300125Z 0 [Warning] [MY-011068] [Server] The syntax '--skip-host-cache' is deprecated and will be removed in a future release. Please use SET GLOBAL host_cache_size=0 instead.
imran-db-1   | 2025-10-14T13:58:08.300223Z 0 [System] [MY-013169] [Server] /usr/sbin/mysqld (mysqld 8.0.43) initializing of server in progress as process 80
imran-db-1   | 2025-10-14T13:58:08.305226Z 1 [System] [MY-013576] [InnoDB] InnoDB initialization has started.
imran-db-1   | 2025-10-14T13:58:08.500118Z 1 [System] [MY-013577] [InnoDB] InnoDB initialization has ended.
Warning: 1   | 2025-10-14T13:58:09.260366Z 6 [Warning] [MY-010453] [Server] root@localhost is created with an empty password ! Please consider switching off the --initialize-insecure option.
imran-db-1   | 2025-10-14 13:58:11+00:00 [Note] [Entrypoint]: Database files initialized
imran-db-1   | 2025-10-14 13:58:11+00:00 [Note] [Entrypoint]: Starting temporary server
Warning: 1   | 2025-10-14T13:58:11.548878Z 0 [Warning] [MY-011068] [Server] The syntax '--skip-host-cache' is deprecated and will be removed in a future release. Please use SET GLOBAL host_cache_size=0 instead.
imran-db-1   | 2025-10-14T13:58:11.549621Z 0 [System] [MY-010116] [Server] /usr/sbin/mysqld (mysqld 8.0.43) starting as process 124
imran-db-1   | 2025-10-14T13:58:11.558157Z 1 [System] [MY-013576] [InnoDB] InnoDB initialization has started.
imran-db-1   | 2025-10-14T13:58:11.653255Z 1 [System] [MY-013577] [InnoDB] InnoDB initialization has ended.
Warning: 1   | 2025-10-14T13:58:11.829021Z 0 [Warning] [MY-010068] [Server] CA certificate ca.pem is self signed.
imran-db-1   | 2025-10-14T13:58:11.829053Z 0 [System] [MY-013602] [Server] Channel mysql_main configured to support TLS. Encrypted connections are now supported for this channel.
Warning: 1   | 2025-10-14T13:58:11.830683Z 0 [Warning] [MY-011810] [Server] Insecure configuration for --pid-file: Location '/var/run/mysqld' in the path is accessible to all OS users. Consider choosing a different directory.
imran-db-1   | 2025-10-14T13:58:11.843146Z 0 [System] [MY-011323] [Server] X Plugin ready for connections. Socket: /var/run/mysqld/mysqlx.sock
imran-db-1   | 2025-10-14T13:58:11.843216Z 0 [System] [MY-010931] [Server] /usr/sbin/mysqld: ready for connections. Version: '8.0.43'  socket: '/var/run/mysqld/mysqld.sock'  port: 0  MySQL Community Server - GPL.
imran-db-1   | 2025-10-14 13:58:11+00:00 [Note] [Entrypoint]: Temporary server started.
imran-db-1   | '/var/lib/mysql/mysql.sock' -> '/var/run/mysqld/mysqld.sock'
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/iso3166.tab' as time zone. Skipping it.
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/leap-seconds.list' as time zone. Skipping it.
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/leapseconds' as time zone. Skipping it.
imran-app-1  |  Failed to connect to database attempt 0
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/tzdata.zi' as time zone. Skipping it.
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/zone.tab' as time zone. Skipping it.
imran-db-1   | Warning: Unable to load '/usr/share/zoneinfo/zone1970.tab' as time zone. Skipping it.
imran-db-1   | 2025-10-14 13:58:13+00:00 [Note] [Entrypoint]: Creating database employees
imran-db-1   | 
imran-db-1   | 2025-10-14 13:58:13+00:00 [Note] [Entrypoint]: Stopping temporary server
imran-db-1   | 2025-10-14T13:58:13.569350Z 11 [System] [MY-013172] [Server] Received SHUTDOWN from user root. Shutting down mysqld (Version: 8.0.43).
imran-db-1   | 2025-10-14T13:58:14.338894Z 0 [System] [MY-010910] [Server] /usr/sbin/mysqld: Shutdown complete (mysqld 8.0.43)  MySQL Community Server - GPL.
imran-db-1   | 2025-10-14 13:58:14+00:00 [Note] [Entrypoint]: Temporary server stopped
imran-db-1   | 
imran-db-1   | 2025-10-14 13:58:14+00:00 [Note] [Entrypoint]: MySQL init process done. Ready for start up.
imran-db-1   | 
Warning: 1   | 2025-10-14T13:58:14.760118Z 0 [Warning] [MY-011068] [Server] The syntax '--skip-host-cache' is deprecated and will be removed in a future release. Please use SET GLOBAL host_cache_size=0 instead.
imran-db-1   | 2025-10-14T13:58:14.761507Z 0 [System] [MY-010116] [Server] /usr/sbin/mysqld (mysqld 8.0.43) starting as process 1
imran-db-1   | 2025-10-14T13:58:14.766479Z 1 [System] [MY-013576] [InnoDB] InnoDB initialization has started.
imran-db-1   | 2025-10-14T13:58:14.865664Z 1 [System] [MY-013577] [InnoDB] InnoDB initialization has ended.
Warning: 1   | 2025-10-14T13:58:15.022561Z 0 [Warning] [MY-010068] [Server] CA certificate ca.pem is self signed.
imran-db-1   | 2025-10-14T13:58:15.022593Z 0 [System] [MY-013602] [Server] Channel mysql_main configured to support TLS. Encrypted connections are now supported for this channel.
Warning: 1   | 2025-10-14T13:58:15.024813Z 0 [Warning] [MY-011810] [Server] Insecure configuration for --pid-file: Location '/var/run/mysqld' in the path is accessible to all OS users. Consider choosing a different directory.
imran-db-1   | 2025-10-14T13:58:15.038765Z 0 [System] [MY-011323] [Server] X Plugin ready for connections. Bind-address: '::' port: 33060, socket: /var/run/mysqld/mysqlx.sock
imran-db-1   | 2025-10-14T13:58:15.038840Z 0 [System] [MY-010931] [Server] /usr/sbin/mysqld: ready for connections. Version: '8.0.43'  socket: '/var/run/mysqld/mysqld.sock'  port: 3306  MySQL Community Server - GPL.
imran-app-1  |  Failed to connect to database attempt 1
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 2
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 3
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 4
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 5
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 6
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 7
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 8
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Connecting to database...
imran-app-1  |  Failed to connect to database attempt 9
imran-app-1  | Communications link failure
imran-app-1  | 
imran-app-1  | The last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.
imran-app-1  | Failed to retrieve countries: Cannot invoke "java.sql.Connection.createStatement()" because "this.con" is null
Aborting on container exit...
imran-app-1 exited with code 0
 Container imran-app-1  Stopping
 Container imran-app-1  Stopped
 Container imran-db-1  Stopping
 Container imran-db-1  Stopped
