import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ironvault_mobile/model/routine_client.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/providers/routineclient_provider.dart';
import 'package:ironvault_mobile/utils/util.dart';
import 'package:ironvault_mobile/widgets/master_screen.dart';
import 'package:provider/provider.dart';

class RoutineClientScreen extends StatefulWidget {
  static const String routeName = "/routineclient";

  const RoutineClientScreen({Key? key}) : super(key: key);

  @override
  State<RoutineClientScreen> createState() => _RoutineClientScreenState();
}

class _RoutineClientScreenState extends State<RoutineClientScreen> {
  late RoutineClientProvider _routineClientProvider;
  late RoutineProvider _routineProvider;

  @override
  void initState() {
    super.initState();
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    _routineClientProvider = context.watch<RoutineClientProvider>();
    _routineProvider = context.read<RoutineProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Column(
        children: [
          Expanded(child: _buildExerciseCardList()),
          _buildAddButton(),
        ],
      ),
    );
  }

  Widget _buildExerciseCardList() {
    return Container(
      child: ListView.builder(
        itemCount: _routineClientProvider.routineClient.items.length,
        itemBuilder: (context, index) {
          return _buildExerciseCard(
              _routineClientProvider.routineClient.items[index]);
        },
      ),
    );
  }

  Widget _buildExerciseCard(RoutineItem item) {
    return ListTile(
      leading: imageFromBase64String(item.exercise.exerciseImage!),
      title: Text(item.exercise.exerciseName ?? ""),
      subtitle: Text(item.exercise.muscleNames ?? ""),
      trailing: Text(item.count.toString()),
    );
  }

  Widget _buildAddButton() {
    return TextButton(
      child: Text("Add"),
      onPressed: () async {
        List<Map> items = [];
        _routineClientProvider.routineClient.items.forEach((item) {
          items.add({
            "exerciseId": item.exercise.exerciseId,
            "count": item.count,
          });
        });
        Map order = {
          "items": items,
        };

        await _routineProvider.insert(order);

        _routineClientProvider.routineClient.items.clear();
        setState(() {});
      },
    );
  }
}
