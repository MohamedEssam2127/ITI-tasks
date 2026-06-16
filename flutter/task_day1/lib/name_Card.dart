import 'package:flutter/material.dart';


class NameCard extends StatelessWidget {
  const NameCard({
    super.key,
    required this.controller,
    required this.focusNode,
    required this.clear,
  });

  final TextEditingController controller;
  final FocusNode focusNode;
 
  final VoidCallback clear;

  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 0,
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            TextField(
              controller: controller,
              focusNode: focusNode,
              textInputAction: TextInputAction.done,
              decoration: InputDecoration(
                labelText: "Name",
                hintText: "Please, enter your name",
                border: OutlineInputBorder(),
                prefixIcon: Icon(Icons.person),
              ),
            ),
            SizedBox(height: 12),
            Row(
              children: [
                SizedBox(width: 12),
                Expanded(
                  child: OutlinedButton.icon(
                    onPressed: clear,
                    label: Text("Clear"),
                    icon: Icon(Icons.clear),
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}