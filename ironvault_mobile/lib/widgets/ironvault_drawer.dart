import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:ironvault_mobile/providers/routine_provider.dart';
import 'package:ironvault_mobile/screens/exercises/exercise_list_screen.dart';
import 'package:provider/provider.dart';

class ironVaultDrawer extends StatelessWidget {
  ironVaultDrawer({Key? key}) : super(key: key);
  RoutineProvider? _routineProvider;

  @override
  Widget build(BuildContext context) {
    _routineProvider = context.watch<RoutineProvider>();
    return Drawer(
      child: ListView(
        children: [
          ListTile(
            title: Text('Home'),
            onTap: () => {
              Navigator.popAndPushNamed(context, ExerciseListScreen.routeName)
            },
          )
        ],
      ),
    );
  }
}
