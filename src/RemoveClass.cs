using System.Collections.Generic;
using System.Linq;

namespace library {
    public class Value {
        public int SomeField;

        public Value (int i) {
            SomeField = i;
        }
    }

    public static class RemoveClass {
        public static void Remove (IList<Value> container, Value data) {
            if (data == null) return;

            if (container.All (c => c.SomeField != data.SomeField)) return;

            container.Remove (data); // очень много связанной логики и т.п.
        }

        public static void RemoveSecond (IList<Value> container, Value data) {
            if (data == null) return;

            var deleteT = container.FirstOrDefault (c => c.SomeField == data.SomeField);
            if (deleteT == null) return;

            container.Remove (deleteT);
        }

        public static void RemoveThird (IList<Value> container, Value data) {
            if (data == null) return;

            var deleteT = container.SingleOrDefault (c => c.SomeField == data.SomeField);

            if (deleteT == null) return;

            container.Remove (deleteT);
        }
    }
}