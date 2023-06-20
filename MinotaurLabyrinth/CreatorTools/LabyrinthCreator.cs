namespace MinotaurLabyrinth
{
    public static class LabyrinthCreator
    {
        const int ScalingFactor = 16;
        static readonly Dictionary<Size, (int rows, int cols)> _mapSizeDimensions = new()
        {
            { Size.Small, (4, 4) },
            { Size.Medium, (6, 6) },
            { Size.Large, (8, 8) },
        };

        /// <summary>
        /// Initializes the map and the player for the labyrinth game.
        /// </summary>
        /// <param name="mapSize">The size of the labyrinth map.</param>
        /// <returns>A tuple containing the initialized map and the player (hero).</returns>
        public static (Map, Hero) InitializeMap(Size mapSize)
        {
            Map map = CreateMap(mapSize);
            ProceduralGenerator.Initialize(map);
            Location start = RandomizeMap(map);
            return (map, InitializePlayer(start));
        }

        /// <summary>
        /// Creates a new map based on the specified size.
        /// </summary>
        /// <param name="mapSize">The size of the labyrinth map.</param>
        /// <returns>A new instance of the Map class.</returns>
        private static Map CreateMap(Size mapSize)
        {
            if (!_mapSizeDimensions.TryGetValue(mapSize, out var dimensions))
            {
                throw new ArgumentException("Unknown map size");
            }

            return new Map(dimensions.rows, dimensions.cols);
        }

        /// <summary>
        /// Randomizes the placement of rooms and entities on the map.
        /// </summary>
        /// <param name="map">The map to be randomized.</param>
        /// <returns>The starting location for the player.</returns>
        private static Location RandomizeMap(Map map)
        {
            Location start = PlaceEntrance(map);
            PlaceSword(map, start);
            AddRooms(RoomType.Pit, map);
            InitializeMonsters(map);
            return start;
        }

        /// <summary>
        /// Places the entrance of the labyrinth on an edge location of the map.
        /// </summary>
        /// <param name="map">The map on which the entrance is placed.</param>
        /// <returns>The location of the entrance.</returns>
        private static Location PlaceEntrance(Map map)
        {
            Location start = ProceduralGenerator.GetRandomEdgeLocation(map);
            map.SetRoomAtLocation(start, RoomType.Entrance);
            return start;
        }

        /// <summary>
        /// Places the sword on a random location not adjacent to the player's starting location.
        /// </summary>
        /// <param name="map">The map on which the sword is placed.</param>
        /// <param name="start">The player's starting location.</param>
        private static void PlaceSword(Map map, Location start)
        {
            Location swordLocation = ProceduralGenerator.GetRandomLocationNotAdjacentTo(start);
            map.SetRoomAtLocation(swordLocation, RoomType.Sword);
        }

        /// <summary>
        /// Adds a specified number of rooms of the given type to the map.
        /// </summary>
        /// <param name="roomType">The type of room to add.</param>
        /// <param name="map">The map on which the rooms are added.</param>
        /// <param name="multiplier">The multiplier to determine the number of rooms to add.</param>
        private static void AddRooms(RoomType roomType, Map map, int multiplier = 1)
        {
            int numRooms = map.Rows * map.Columns * multiplier / ScalingFactor;
            for (int i = 0; i < numRooms; ++i)
            {
                map.SetRoomAtLocation(ProceduralGenerator.GetRandomLocation(), roomType);
            }
        }

        /// <summary>
        /// Initializes the player (hero) at the specified starting location.
        /// </summary>
        /// <param name="start">The player's starting location.</param>
        /// <returns>An instance of the Hero class representing the player.</returns>
        private static Hero InitializePlayer(Location start)
        {
            return new Hero(start);
        }

        /// <summary>
        /// Initializes monsters on the map by adding a Minotaur to a random location.
        /// </summary>
        /// <param name="map">The map on which monsters are initialized.</param>
        private static void InitializeMonsters(Map map)
        {
            Location minotaurLocation = ProceduralGenerator.GetRandomLocation();
            Room room = map.GetRoomAtLocation(minotaurLocation);
            room.AddMonster(new Minotaur());
        }
    }
}
