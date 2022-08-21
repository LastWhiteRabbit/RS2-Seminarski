// import 'package:eprodajamobile/model/cart.dart';
// import 'package:eprodajamobile/providers/cart_provider.dart';
// import 'package:eprodajamobile/widgets/eprodaja_drawer.dart';
// import 'package:eprodajamobile/widgets/master_screen.dart';
// import 'package:flutter/cupertino.dart';
// import 'package:flutter/material.dart';
// import 'package:flutter/src/foundation/key.dart';
// import 'package:flutter/src/widgets/framework.dart';
// import 'package:ironvault_mobile/providers/routine_provider.dart';
// import 'package:provider/provider.dart';

// import '../../providers/order_provider.dart';
// import '../../utils/util.dart';

// class RoutineScreen extends StatefulWidget {
//   static const String routeName = "/Routine";

//   const RoutineScreen({Key? key}) : super(key: key);

//   @override State<RoutineScreen> createState() => _RoutineScreenState();
// }
// class _RoutineScreenState extends State<RoutineScreen> {

//   late RoutineProvider _routineProvider;
//   late OrderProvider _orderProvider;

//   @override
//   void initState() {
//     // TODO: implement initState
//     super.initState();

//   }

//   @override
//   void didChangeDependencies() {
//     // TODO: implement didChangeDependencies
//     super.didChangeDependencies();
//     _routineProvider = context.watch<RoutineProvider>();
//     _orderProvider = context.read<OrderProvider>();
//   }

//   @override
//   Widget build(BuildContext context) {
//     return Container();
//     return MasterScreenWidget(
//         child: Column(
//           children: [
//             Expanded(child:_buildProductCardList()),
//             _buildBuyButton(),
//           ],
//         ),
//       );
//   }

//   Widget _buildExerciseCardList() {
//     return Container(
//       child: ListView.builder(
//         //itemCount: _routineProvider.cart.items.length,
//         itemCount: 1,
//         itemBuilder: (context, index) {
//           return _buildExerciseCard(_routineProvider.routine.items[index]);
//         },
//       ),
//     );
//   }

//   Widget _buildExerciseCard(CartItem item) {
//     return ListTile(
//       leading: imageFromBase64String(item.product.slika!),
//       title: Text(item.product.naziv ?? ""),
//       subtitle: Text(item.product.cijena.toString()),
//       trailing: Text(item.count.toString()),
//     );
//   }

//   Widget _buildBuyButton() {
//     return TextButton(
//       child: Text("Buy"),
//       onPressed: () async {
//         List<Map> items = [];
//         _cartProvider.cart.items.forEach((item) {
//           items.add({
//             "proizvodId": item.product.proizvodId,
//             "kolicina": item.count,
//           });
//         });
//         Map order = {
//           "items": items,
//         };

//         await _orderProvider.insert(order);

//         _cartProvider.cart.items.clear();
//         setState(() {
//         });
//       },
//     );
//   }
// } 
// }