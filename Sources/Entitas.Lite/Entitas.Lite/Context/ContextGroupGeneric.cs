namespace Entitas
{
	public static class ContextGroupGeneric
	{
		public static Group AllOf<T1>(this Context c) where T1 : IComponent
			=> c.GetGroup(MatcherCache<T1>.AllOf());
		public static Group AllOf<T1, T2>(this Context c) where T1 : IComponent where T2 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2>.AllOf());
		public static Group AllOf<T1, T2, T3>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3>.AllOf());
		public static Group AllOf<T1, T2, T3, T4>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4>.AllOf());
		public static Group AllOf<T1, T2, T3, T4, T5>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5>.AllOf());
		public static Group AllOf<T1, T2, T3, T4, T5, T6>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6>.AllOf());
		public static Group AllOf<T1, T2, T3, T4, T5, T6, T7>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent where T7 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6, T7>.AllOf());

		public static Group AnyOf<T1>(this Context c) where T1 : IComponent
			=> c.GetGroup(MatcherCache<T1>.AnyOf());
		public static Group AnyOf<T1, T2>(this Context c) where T1 : IComponent where T2 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2>.AnyOf());
		public static Group AnyOf<T1, T2, T3>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3>.AnyOf());
		public static Group AnyOf<T1, T2, T3, T4>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4>.AnyOf());
		public static Group AnyOf<T1, T2, T3, T4, T5>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5>.AnyOf());
		public static Group AnyOf<T1, T2, T3, T4, T5, T6>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6>.AnyOf());
		public static Group AnyOf<T1, T2, T3, T4, T5, T6, T7>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent where T7 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6, T7>.AnyOf());

		/*
		public static Group NoneOf<T1>(this Context c) where T1 : IComponent
			=> c.GetGroup(MatcherCache<T1>.NoneOf());
		public static Group NoneOf<T1, T2>(this Context c) where T1 : IComponent where T2 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2>.NoneOf());
		public static Group NoneOf<T1, T2, T3>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3>.NoneOf());
		public static Group NoneOf<T1, T2, T3, T4>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4>.NoneOf());
		public static Group NoneOf<T1, T2, T3, T4, T5>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5>.NoneOf());
		public static Group NoneOf<T1, T2, T3, T4, T5, T6>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6>.NoneOf());
		public static Group NoneOf<T1, T2, T3, T4, T5, T6, T7>(this Context c) where T1 : IComponent where T2 : IComponent where T3 : IComponent where T4 : IComponent where T5 : IComponent where T6 : IComponent where T7 : IComponent
			=> c.GetGroup(MatcherCache<T1, T2, T3, T4, T5, T6, T7>.NoneOf());
		*/
	}
}
